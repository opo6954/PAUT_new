﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Xml;

namespace vrat
{
    /*
     * list 형태의 data를 다루는 xmlTemplate임
     * */
    public class ListOfXmlTemplate : XmlTemplate
    {
        List<XmlTemplate> xmlTemplateList = new List<XmlTemplate>();
        public int selectedIdx = 0;


        public override System.Xml.XmlElement XmlSerialize(System.Xml.XmlDocument document, System.Xml.XmlElement parentElement, bool isRoot)
        {  
            string propertyName = Name;
            string propertyType = Type;

            XmlElement individualProperty = document.CreateElement(this.GetType().ToString());
            
            individualProperty.SetAttribute("name", propertyName);
            individualProperty.SetAttribute("type", propertyType);
            individualProperty.SetAttribute("idx", selectedIdx.ToString());

            parentElement.AppendChild(individualProperty);
            
            foreach(XmlTemplate q in xmlTemplateList)
            {
                q.XmlSerialize(document, individualProperty,false);
            }

            return individualProperty;
        }

        public int getLengthofList()
        {
            return xmlTemplateList.Count;
        }

        public ListOfXmlTemplate(string _name, string _type, int _idx) : base(_name, _type)
        {
            selectedIdx = _idx;
            ClassName = "ListOfXmlTemplate";

        }

        public void setIdx(int _idx)
        {
            selectedIdx = _idx;
        }


        public bool addList(XmlTemplate _xt)
        {
            foreach (XmlTemplate xt in xmlTemplateList)
            {
                if (xt.Name == _xt.Name)
                {
                    Debug.Log("already exist same name...");
                    return false;
                }
            }
            
            xmlTemplateList.Add(_xt);
            return true;
        }

        public bool deleteListEnd()
        {
            if (xmlTemplateList.Count > 0)
            {
                xmlTemplateList.RemoveAt(xmlTemplateList.Count - 1);
                return true;
            }
            Debug.Log("Not enough xmlTemplaetList... it is already empty");
            return false;
        }
        public bool deleteList(XmlTemplate _xt) 
        {
            foreach (XmlTemplate xt in xmlTemplateList)
            {
                if (xt.Name == _xt.Name)
                {
                    xmlTemplateList.Remove(xt);
                    return true;
                }
            }
            Debug.Log("Not found the name given...");
            return false;
        }

        public List<string> getListofAllName()
        {
            List<string> nameList = new List<string>();
            for (int i = 0; i < xmlTemplateList.Count; i++)
            {
                nameList.Add(xmlTemplateList[i].Type + ":" +  xmlTemplateList[i].Name);
            }

            return nameList;
        }

        public XmlTemplate getXmlTemplate(int idx)
        {
            if(xmlTemplateList.Count > idx)
            {
                Debug.Log(xmlTemplateList[idx].Name);
                return xmlTemplateList[idx];
            }

            return new NullXmlTemplate();
        }

        public XmlTemplate getXmlTemplate(string name)
        {
            foreach (XmlTemplate xt in xmlTemplateList)
            {
                if (xt.Name == name)
                    return xt;
            }

            return new NullXmlTemplate();
        }
        
    }
}