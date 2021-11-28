#pragma once
#include <iostream>
#include "rapidxml.hpp"
#include "rapidxml_utils.hpp"

class RapidXmlTest
{
public:
	RapidXmlTest();
	~RapidXmlTest() {};
private:
	void show_xml(rapidxml::xml_node<>* node,int indent = 0);
};
