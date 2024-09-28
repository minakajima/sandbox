#include <iostream>
#include <sqlite\sqlite3.h>
#include <thread>
#include <vector>
#include <mutex>
#include <string>

std::mutex db_mutex;

/**
 * @brief 指定されたSQLiteデータベースでSQLクエリを実行します。
 * 
 * @param db SQLiteデータベースへのポインタ。
 * @param query 実行するSQLクエリ。
 */
void execute_query(sqlite3* db, const std::string& query) {
    std::unique_lock<std::mutex> lock(db_mutex);
    char* errMsg = nullptr;
    int rc = sqlite3_exec(db, query.c_str(), nullptr, nullptr, &errMsg);
    if (rc != SQLITE_OK) {
        std::cerr << "SQL error: " << errMsg << std::endl;
        sqlite3_free(errMsg);
    } else {
        std::cout << "Query executed successfully: " << query << std::endl;
    }
}

/**
 * @brief 各スレッドによって実行される関数。test_tableにレコードを挿入します。
 * 
 * @param db SQLiteデータベースへのポインタ。
 * @param thread_id スレッドのID。レコードIDとして使用されます。
 */
void thread_function(sqlite3* db, int thread_id) {
    std::string query = "INSERT INTO test_table (id, value) VALUES (" + std::to_string(thread_id) + ", 'Thread " + std::to_string(thread_id) + "')";
    execute_query(db, query);
}

/**
 * @brief メイン関数。SQLiteデータベースを開き、テーブルを作成し、複数のスレッドを開始してレコードを挿入します。
 * 
 * @return int 終了ステータス。
 */
int main() {
    std::cout << "Hello World!\n";

    sqlite3* db;
    int rc = sqlite3_open("test.db", &db);
    if (rc) {
        std::cerr << "Can't open database: " << sqlite3_errmsg(db) << std::endl;
        sqlite3_close(db); // データベースが開けなかった場合にリソースを解放
        return rc;
    } else {
        std::cout << "Opened database successfully" << std::endl;
    }

    // テーブルを作成
    std::string create_table_query = "CREATE TABLE IF NOT EXISTS test_table (id INT, value TEXT);";
    execute_query(db, create_table_query);

    // スレッドを作成して実行
    const int num_threads = 5;
    std::vector<std::thread> threads;
    for (int i = 0; i < num_threads; ++i) {
        threads.emplace_back(thread_function, db, i);
    }

    // スレッドの終了を待つ
    for (auto& th : threads) {
        th.join();
    }

    sqlite3_close(db);
    return 0;
}

// プログラムの実行: Ctrl + F5 または [デバッグ] > [デバッグなしで開始] メニュー
// プログラムのデバッグ: F5 または [デバッグ] > [デバッグの開始] メニュー

// 作業を開始するためのヒント: 
//    1. ソリューション エクスプローラー ウィンドウを使用してファイルを追加/管理します 
//   2. チーム エクスプローラー ウィンドウを使用してソース管理に接続します
//   3. 出力ウィンドウを使用して、ビルド出力とその他のメッセージを表示します
//   4. エラー一覧ウィンドウを使用してエラーを表示します
//   5. [プロジェクト] > [新しい項目の追加] と移動して新しいコード ファイルを作成するか、[プロジェクト] > [既存の項目の追加] と移動して既存のコード ファイルをプロジェクトに追加します
//   6. 後ほどこのプロジェクトを再び開く場合、[ファイル] > [開く] > [プロジェクト] と移動して .sln ファイルを選択します
