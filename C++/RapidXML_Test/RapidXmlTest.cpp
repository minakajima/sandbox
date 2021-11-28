//#include "pch.h"
#include "RapidXmlTest.h"

RapidXmlTest::RapidXmlTest()
{
	//Xmlを読み込むDOM
	rapidxml::xml_document<> doc;
	//RapidXmlのユーティリティクラス　読み込んだXmlファイルをオンメモリに保持してくれる
	rapidxml::file<> file("Test.xml");
	try 
	{
		//Xmlデータをパースする
		doc.parse<0>(file.data());
	}
	catch (rapidxml::parse_error& err) 
	{
		//エラーが出たら原因と場所(ポインタ)を教えてくれる
		std::cout << err.what() << " " << err.where<char*>();
		return;
	}
	//Xmlファイルのデータを表示
	show_xml(doc.first_node());
}

void RapidXmlTest::show_xml(rapidxml::xml_node<>* node,int indent)
{
	//ノードがなければなにもしない
	if (node == nullptr) return;
	//名前があるか
	if (node->name_size() > 0) 
	{
		//インデント分タブ入れる
		for (int i = 0; i < indent; i++) std::cout << "\t";
		std::cout << "Node:" << node->name() << "\n"; 
	}
	else return;
	//値があるか
	if (node->value_size() > 0)
	{
		//インデントとノード分タブ入れる
		for (int i = 0; i < indent + 1; i++) std::cout << "\t";
		std::cout << "Value:" << node->value() << "\n";
	}
	//子ノードへ
	show_xml(node->first_node(),indent + 1);
	//弟ノードへ
	show_xml(node->next_sibling(),indent);
}
