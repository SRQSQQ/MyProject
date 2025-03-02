/*
 * DownloadTask
 * 
 * 2014年11月12日
 * 
 * 宋润强
 * 
 * 下载更新用apk
 */

/*<font color="#333333"><font face="Arial">*/
package com.security.model;

import java.io.File;
import java.io.FileOutputStream;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;

import android.app.ProgressDialog;

public class DownloadTask
{
    /*
     * getFile()
     * 
     * 通过Url获取update.xml
     *     
     * @param path Url
     * 
     * @param filePath apk路径
     * 
     * @param progressDialog 进度条
     * 
     * @return file
     * 
     * @throws Exception
     */
    public static File getFile(String path, String filePath, ProgressDialog progressDialog) throws Exception
    {
        URL url = new URL(path);
        HttpURLConnection httpURLConnection = (HttpURLConnection) url.openConnection();
        httpURLConnection.setConnectTimeout(2000);
        httpURLConnection.setRequestMethod("GET");
        if(httpURLConnection.getResponseCode() == 200)
        {
            int total = httpURLConnection.getContentLength();
            progressDialog.setMax(total);
            
            InputStream is = httpURLConnection.getInputStream();
            File file = new File(filePath);
            FileOutputStream fos = new FileOutputStream(file);
            byte[] buffer = new byte[1024];
            int len;
            int process = 0;
            while((len = is.read(buffer)) != -1)
            {
                fos.write(buffer, 0, len);
                process += len;
                progressDialog.setProgress(process);
            }
            fos.flush();
            fos.close();
            is.close();
            return file;
        }
        return null;
    }
}
/*</font></font>*/
