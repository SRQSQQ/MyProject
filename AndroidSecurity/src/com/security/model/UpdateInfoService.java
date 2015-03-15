/*
 * UpdateInfoService
 * 
 * 2014��11��11��
 * 
 * ��׿��ʿ
 * 
 * ͨ��Url��ȡupdate.xml
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
     * ͨ��Url��ȡupdate.xml
     * 
	 * @param urlId��Url�� 	
	 * 
     * @return UpdateInfo��������Ϣ��
     * 
     * @throws Exception
     */
    public UpdateInfo getUpdateInfo(int urlId) throws Exception
    {
            String path = context.getResources().getString(urlId);//�õ�config.xml�����ŵĵ�ַ
            URL url = new URL(path);
            HttpURLConnection httpURLConnection = (HttpURLConnection) url.openConnection();//����һ��http����
            httpURLConnection.setConnectTimeout(5000);//�������ӵĳ�ʱʱ�䣬����Ϊ5��
            httpURLConnection.setRequestMethod("GET");//��������ķ�ʽ
            InputStream is = httpURLConnection.getInputStream();//�õ�һ�������������������update.xml����Ϣ
            return UpdateInfoParser.getUpdateInfo(is);//����xml
    }
}
