/*
 * UpdateInfoParser
 * 
 * 2014��11��11��
 * 
 * ��׿��ʿ
 * 
 * ����XML�ļ�
 */
package com.security.model;

import java.io.InputStream;

import org.xmlpull.v1.XmlPullParser;

import android.util.Xml;

public class UpdateInfoParser {
	
    /*
     * getUpdateInfo()
     * 
     * ����XML�ļ�
     * 
	 * @param is���������� 	
	 * 
     * @return UpdateInfo��������Ϣ��
     * 
     * @throws Exception
     */
    public static UpdateInfo getUpdateInfo(InputStream is) throws Exception
    {    	
        UpdateInfo info = new UpdateInfo();
        XmlPullParser xmlPullParser = Xml.newPullParser();
        xmlPullParser.setInput(is, "gb2312");
        int type = xmlPullParser.getEventType();
        while(type != XmlPullParser.END_DOCUMENT)
        {
            switch(type)
            {
                case XmlPullParser.START_TAG :
                    if(xmlPullParser.getName().equals("version"))
                    {
                            info.setVersion(xmlPullParser.nextText());
                    }
                    else if(xmlPullParser.getName().equals("description"))
                    {
                            info.setDescription(xmlPullParser.nextText());
                    }
                    else if(xmlPullParser.getName().equals("apkurl"))
                    {
                            info.setUrl(xmlPullParser.nextText());
                    }
                    break;
                        
                default : 
                        break;
            }
            type = xmlPullParser.next();
        }
        return info;
    }
}
