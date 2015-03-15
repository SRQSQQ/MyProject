/*
 * LogoActivity
 * 
 * Version 1.0
 * 
 * 2014年11月10日
 * 
 * 宋润强
 * 
 * 启动界面
 */
package com.example.androidsecurity;

import java.io.File;

import com.security.model.DownloadTask;
import com.security.model.UpdateInfo;
import com.security.model.UpdateInfoService;

import android.support.v7.app.ActionBarActivity;
import android.support.v4.app.Fragment;
import android.app.AlertDialog;
import android.app.ProgressDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.pm.PackageInfo;
import android.content.pm.PackageManager;
import android.content.pm.PackageManager.NameNotFoundException;
import android.net.Uri;
import android.os.Bundle;
import android.os.Environment;
import android.os.Handler;
import android.os.Looper;
import android.os.Message;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.ViewGroup;
import android.view.Window;
import android.view.WindowManager;
import android.view.animation.AlphaAnimation;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.Toast;

public class LogoActivity extends ActionBarActivity {
    private TextView txt_version;
    private LinearLayout logo_main;
    private ProgressDialog progressDialog;
    
    private UpdateInfo info;
    
    //消息处理
    private Handler handler = new Handler() {
    	
        @Override
        public void handleMessage(Message msg) {
            super.handleMessage(msg);
            Log.i("LogoActivity", msg.what+"");
            switch (msg.what) {
            case 1:
            	//更新提醒
                showUpdateDialog();
                break;
            }
        }
    };
	
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        
        //设置不要显示标题栏
        requestWindowFeature(Window.FEATURE_NO_TITLE);        
        
        setContentView(R.layout.logo);
        
        //解决主线程网络异常方法一：禁用规则StrictMode	简单暴力，强制使用，代码修改简单（但是非常不推荐）
        /*if (android.os.Build.VERSION.SDK_INT > 9) {
            StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();
            StrictMode.setThreadPolicy(policy);
        }*/
        
        //设置全屏显示
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
        		WindowManager.LayoutParams.FLAG_FULLSCREEN);
        
        txt_version = (TextView) findViewById(R.id.txt_version);
        //获取版本信息
        String version = getVersion();
        txt_version.setText("版本号  " + version);
        
        logo_main = (LinearLayout) findViewById(R.id.logo_main);
        //渐变特效
        AlphaAnimation alphaAnimation = new AlphaAnimation(0.0f, 1.0f);        
        alphaAnimation.setDuration(2000);
        logo_main.startAnimation(alphaAnimation);
        
        //进度条
        progressDialog = new ProgressDialog(this);
        progressDialog.setProgressStyle(ProgressDialog.STYLE_HORIZONTAL);
        progressDialog.setMessage("正在下载...");
        
        //解决主线程网络异常方法二：启动线程
        Runnable r = new UpdateHandler();
        Thread thread = new Thread(r);  
        thread.start();         
    }
    
    /*
     * showUpdateDialog()
     * 
     * 更新提醒 	 
     */
    private void showUpdateDialog()
    {
        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.setIcon(android.R.drawable.ic_dialog_info);
        builder.setTitle("升级提醒");
        builder.setMessage(info.getDescription());
        builder.setCancelable(false);
        
        builder.setPositiveButton("确定", new DialogInterface.OnClickListener()
        {
                
            @Override
            public void onClick(DialogInterface dialog, int which)
            {
                // TODO Auto-generated method stub
            	if(Environment.getExternalStorageState().equals(Environment.MEDIA_MOUNTED))
                {
                    File dir = new File(Environment.getExternalStorageDirectory(), "/security/update");
                    if(!dir.exists())
                    {
                            dir.mkdirs();
                    }
                    String apkPath = Environment.getExternalStorageDirectory() + "/security/update/new.apk";
                    UpdateTask task = new UpdateTask(info.getUrl(), apkPath);
                    progressDialog.show();
                    new Thread(task).start();
                }
                else
                {
                    Toast.makeText(LogoActivity.this, "SD卡不可用，请插入SD卡", Toast.LENGTH_SHORT).show();
                    loadMainUI();
                }
                    
            }
        });
        builder.setNegativeButton("取消", new DialogInterface.OnClickListener()
        {

            @Override
            public void onClick(DialogInterface dialog, int which)
            {
                // TODO Auto-generated method stub
                loadMainUI();
                    
            }
                
        });
        builder.create().show();
    }
    
    /*
     * isNeedUpdate()
     * 
     * 判断是否需要更新
     * 
	 * @param version 	
	 * 
     * @return boolean
     */
    private boolean isNeedUpdate(String version)
    {
        UpdateInfoService updateInfoService = new UpdateInfoService(this);
        try
        {
        	//通过Url获取版本信息
            info = updateInfoService.getUpdateInfo(R.string.serverUrl);
            String v = info.getVersion();
            //通过版本号判断是否需要更新
            if(v.equals(version))
            {
                System.out.println("不用更新");
                return false;
            }
            else
            {
                System.out.println("要更新");
                return true;
            }
        }
        catch (Exception e)
        {
            Log.e("LogoActivity", "Exception: "+Log.getStackTraceString(e));
            Toast.makeText(this, "获取更新信息异常，请稍后再试", Toast.LENGTH_LONG).show();
        }
        return false;
    }

    /*
     * getVersion()
     * 
     * 获取程序版本号
     * 
     * @return versionName（版本号）
     */
    private String getVersion() {
        try {
                PackageManager packageManager = getPackageManager();
                PackageInfo packageInfo = packageManager.getPackageInfo(getPackageName(), 0);
                
                return packageInfo.versionName;
        } catch (NameNotFoundException e) {
                e.printStackTrace();
                return "版本号未知";
        }
    }
    
    /*
     * UpdateHandler
     * 
     * 2014年11月11日
     * 
     * 宋润强
     * 
     * 查询更新的线程（0.4以后不能在主线程处理网络相关）
     */
    private class UpdateHandler implements Runnable {
        Message msg = new Message();
        
        @Override
        public void run() {
            Looper.prepare();
            //判断是否有新版本
            if(isNeedUpdate(getVersion())) {
                msg.what = 1;
            }
            handler.sendMessage(msg);
            Looper.loop();
        }            
    }

    /*
     * UpdateTask
     * 
     * 2014年11月12日
     * 
     * 宋润强
     * 
     * 下载的线程
     */
    class UpdateTask implements Runnable
    {
        private String path;
        private String filePath;
        
        public UpdateTask(String path, String filePath)
        {
            this.path = path;
            this.filePath = filePath;
        }

        @Override
        public void run()
        {
            try
            {
                File file = DownloadTask.getFile(path, filePath, progressDialog);
                progressDialog.dismiss();
                install(file);
            }
            catch (Exception e)
            {
            	Log.e("LogoActivity", "Exception: "+Log.getStackTraceString(e));	            
	            progressDialog.dismiss();
	            Toast.makeText(LogoActivity.this, "更新失败", Toast.LENGTH_SHORT).show();
	            loadMainUI();
            }
        }            
    }
    
    /*
     * 安装apk
     * 
     * @param file 要安装的apk的目录
     */
    private void install(File file)
    {
            Intent intent = new Intent();
            intent.setAction(Intent.ACTION_VIEW);
            intent.setDataAndType(Uri.fromFile(file), "application/vnd.android.package-archive");
            finish();
            startActivity(intent);
    }
    
    private void loadMainUI()
    {
            Intent intent = new Intent(this, LogoActivity.class);
            startActivity(intent);
            finish();
    }
    
    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.logo, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();
        if (id == R.id.action_settings) {
            return true;
        }
        return super.onOptionsItemSelected(item);
    }

    /**
     * A placeholder fragment containing a simple view.
     */
    public static class PlaceholderFragment extends Fragment {

        public PlaceholderFragment() {
        }

        @Override
        public View onCreateView(LayoutInflater inflater, ViewGroup container,
                Bundle savedInstanceState) {
            View rootView = inflater.inflate(R.layout.fragment_logo, container, false);
            return rootView;
        }
    }

}
