package com.example.healthclock;

import tool.DBManager;
import android.content.Intent;
import android.os.Bundle;
import android.os.Handler;
import android.support.v7.app.ActionBarActivity;
import android.view.Window;

public class LogoActivity extends ActionBarActivity {
	private final int SPLASH_DISPLAY_LENGHT = 4000;	//延迟四秒
	
	public DBManager dbHelper;
	
	@Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        setContentView(R.layout.logo_main);
        
        //导入数据库
        dbHelper = new DBManager(this);
        dbHelper.openDatabase();
        dbHelper.closeDatabase();
        
        /**
         * 功能  启动新的Activity
         */
        new Handler().postDelayed(new Runnable() {  
            public void run() {  
                Intent mainIntent = new Intent(LogoActivity.this,  
                        MainActivity.class);  
                LogoActivity.this.startActivity(mainIntent);	//启动新的Activity
                LogoActivity.this.finish();	//关闭当前Activity
            }  
  
        }, SPLASH_DISPLAY_LENGHT);
	}	
}
