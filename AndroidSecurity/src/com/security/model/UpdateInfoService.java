/*
 * UpdateInfoService
 * 
 * 2014年11月11日
 * 
 * 安卓巴士
 * 
 * 通过Url获取update.xml
 */
package com.security.model;

import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;

import android.content.Context;

public class UpdateInfoService {
    private Context context;
    
    public UpdateInfoService(Context context)
    {
            this.context = context;
    }
    
    /*
     * getUpdateInfo()
     * 
     * 通过Url获取update.xml
     * 
	 * @param urlId（Url） 	
	 * 
     * @return UpdateInfo（更新信息）
     * 
     * @throws Exception
     */
    public UpdateInfo getUpdateInfo(int urlId) throws Exception
    {
            String path = context.getResources().getString(urlId);//拿到config.xml里面存放的地址
            URL url = new URL(path);
            HttpURLConnection httpURLConnection = (HttpURLConnection) url.openConnection();//开启一个http链接
            httpURLConnection.setConnectTimeout(5000);//设置链接的超时时间，现在为5秒
            httpURLConnection.setRequestMethod("GET");//设置请求的方式
            InputStream is = httpURLConnection.getInputStream();//拿到一个输入流。里面包涵了update.xml的信息
            return UpdateInfoParser.getUpdateInfo(is);//解析xml
    }
}
