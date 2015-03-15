/*
 * UpdateInfoParser
 * 
 * 2014年11月11日
 * 
 * 安卓巴士
 * 
 * 解析XML文件
 */
package com.security.model;

import java.io.InputStream;

import org.xmlpull.v1.XmlPullParser;

import android.util.Xml;

public class UpdateInfoParser {
	
    /*
     * getUpdateInfo()
     * 
     * 解析XML文件
     * 
	 * @param is（输入流） 	
	 * 
     * @return UpdateInfo（更新信息）
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
