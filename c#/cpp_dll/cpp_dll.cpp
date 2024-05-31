// cpp_dll.cpp : DLL 用にエクスポートされる関数を定義します。
//

#include "pch.h"
#include "framework.h"
#include "cpp_dll.h"


// これは、エクスポートされた変数の例です
CPPDLL_API int ncppdll=0;

// これは、エクスポートされた関数の例です。
CPPDLL_API int fncppdll(void)
{
    return 0;
}

// これは、エクスポートされたクラスのコンストラクターです。
Ccppdll::Ccppdll()
{
    return;
}
