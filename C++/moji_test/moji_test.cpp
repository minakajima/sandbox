// moji_test.cpp : このファイルには 'main' 関数が含まれています。プログラム実行の開始と終了がそこで行われます。
//

#include <iostream>
#include <atlstr.h>
#include <string>
#include "strconv.h"

int wmain(int argCount, wchar_t* argValue[])
{
    CString str(_T("日本語"));
    std::string utf8_str(u8"あいう");


#ifdef _UNICODE
    std::wcout.imbue(std::locale("japanese"));
    std::wcout << str.GetBuffer() << std::endl;
    std::wcout << std::wstring(str.GetBuffer()).c_str() << std::endl;

    std::wcout << utf8_to_wide(utf8_str).c_str() << std::endl;
#else
    std::cout << str.GetBuffer() << std::endl;
    std::cout << std::string(str.GetBuffer()).c_str() << std::endl;
    std::cout << utf8_to_ansi(utf8_str).c_str() << std::endl;
#endif
    std::cout << "Hello World!\n";

//    dbgmsg(_T("test"), utf8_to_wide(utf8_str).c_str());
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
