/*
 * logo界面
 */
package com.example.androidexpressage;


import com.example.tool.DBManager;

import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.graphics.Typeface;
import android.os.Bundle;
import android.os.Handler;
import android.support.v7.app.ActionBarActivity;
import android.view.Window;

public class LogoActivity extends ActionBarActivity {
	private final int SPLASH_DISPLAY_LENGHT = 4000;	//延迟四秒
	
	public DBManager dbHelper;
	SQLiteDatabase database = null;
	Cursor cur = null;
	
//	static Typeface typeface;	//通过自定义字体生成字体对象
	
	@Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        setContentView(R.layout.logo_main);
        
//        typeface = Typeface.createFromAsset(getAssets(), "fonts/regular.otf");
        
        //导入数据库
        dbHelper = new DBManager(this);
        dbHelper.openDatabase();        
        dbHelper.closeDatabase();
        
        database = SQLiteDatabase.openOrCreateDatabase(DBManager.DB_PATH + "/" + DBManager.DB_NAME, null);
        database.execSQL(" create table if not exists Save(_id integer primary key autoincrement,快递单号 text,快递名称 text,保存日期 text) ");
//        database.execSQL("delete from Save");
//        database.execSQL("insert into Save values(NULL, '701483843632', '圆通快递','2015-04-05')");
//        cur = database.rawQuery("select 快递单号 from SaveKD where 快递名称 = '圆通快递'", null);
//        if (cur != null) {	    
//        	if (cur.moveToFirst()) {
//        		System.out.println("############" + cur.getString(cur.getColumnIndex("快递单号")));
//        	}
//        }
        database.close();
        
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
