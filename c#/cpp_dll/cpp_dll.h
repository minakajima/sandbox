// 以下の ifdef ブロックは、DLL からのエクスポートを容易にするマクロを作成するための
// 一般的な方法です。この DLL 内のすべてのファイルは、コマンド ラインで定義された CPPDLL_EXPORTS
// シンボルを使用してコンパイルされます。このシンボルは、この DLL を使用するプロジェクトでは定義できません。
// ソースファイルがこのファイルを含んでいる他のプロジェクトは、
// CPPDLL_API 関数を DLL からインポートされたと見なすのに対し、この DLL は、このマクロで定義された
// シンボルをエクスポートされたと見なします。
#ifdef CPPDLL_EXPORTS
#define CPPDLL_API __declspec(dllexport)
#else
#define CPPDLL_API __declspec(dllimport)
#endif

// このクラスは dll からエクスポートされました
class CPPDLL_API Ccppdll {
public:
	Ccppdll(void);
	// TODO: メソッドをここに追加します。
};

extern CPPDLL_API int ncppdll;

CPPDLL_API int fncppdll(void);
