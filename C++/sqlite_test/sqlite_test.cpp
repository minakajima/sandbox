// sqlite_test.cpp : このファイルには 'main' 関数が含まれています。プログラム実行の開始と終了がそこで行われます。
//

#include <iostream>
#include <sqlite\sqlite3.h>
#include <thread>
#include <vector>
#include <mutex>
#include <string>

std::mutex db_mutex;

void execute_query(sqlite3* db, const std::string& query) {
    std::lock_guard<std::mutex> lock(db_mutex);
    char* errMsg = nullptr;
    int rc = sqlite3_exec(db, query.c_str(), nullptr, nullptr, &errMsg);
    if (rc != SQLITE_OK) {
        std::cerr << "SQL error: " << errMsg << std::endl;
        sqlite3_free(errMsg);
    }
    else {
        std::cout << "Query executed successfully: " << query << std::endl;
    }
}

void thread_function(sqlite3* db, int thread_id) {
    std::string query = "INSERT INTO test_table (id, value) VALUES (" + std::to_string(thread_id) + ", 'Thread " + std::to_string(thread_id) + "')";
    execute_query(db, query);
}


int main()
{
    std::cout << "Hello World!\n";

    sqlite3* db;
    int rc = sqlite3_open("test.db", &db);
    if (rc) {
        std::cerr << "Can't open database: " << sqlite3_errmsg(db) << std::endl;
        return rc;
    }
    else {
        std::cout << "Opened database successfully" << std::endl;
    }

    // Create table
    std::string create_table_query = "CREATE TABLE IF NOT EXISTS test_table (id INT, value TEXT);";
    execute_query(db, create_table_query);

    // Create and run threads
    const int num_threads = 5;
    std::vector<std::thread> threads;
    for (int i = 0; i < num_threads; ++i) {
        threads.emplace_back(thread_function, db, i);
    }

    // Join threads
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
