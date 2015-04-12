/*
 * logo����
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
	private final int SPLASH_DISPLAY_LENGHT = 4000;	//�ӳ�����
	
	public DBManager dbHelper;
	SQLiteDatabase database = null;
	Cursor cur = null;
	
//	static Typeface typeface;	//ͨ���Զ������������������
	
	@Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        setContentView(R.layout.logo_main);
        
//        typeface = Typeface.createFromAsset(getAssets(), "fonts/regular.otf");
        
        //�������ݿ�
        dbHelper = new DBManager(this);
        dbHelper.openDatabase();        
        dbHelper.closeDatabase();
        
        database = SQLiteDatabase.openOrCreateDatabase(DBManager.DB_PATH + "/" + DBManager.DB_NAME, null);
        database.execSQL(" create table if not exists Save(_id integer primary key autoincrement,��ݵ��� text,������� text,�������� text) ");
//        database.execSQL("delete from Save");
//        database.execSQL("insert into Save values(NULL, '701483843632', 'Բͨ���','2015-04-05')");
//        cur = database.rawQuery("select ��ݵ��� from SaveKD where ������� = 'Բͨ���'", null);
//        if (cur != null) {	    
//        	if (cur.moveToFirst()) {
//        		System.out.println("############" + cur.getString(cur.getColumnIndex("��ݵ���")));
//        	}
//        }
        database.close();
        
        /**
         * ����  �����µ�Activity
         */
        new Handler().postDelayed(new Runnable() {  
            public void run() {  
                Intent mainIntent = new Intent(LogoActivity.this,  
                        MainActivity.class);  
                LogoActivity.this.startActivity(mainIntent);	//�����µ�Activity
                LogoActivity.this.finish();	//�رյ�ǰActivity
            }  
  
        }, SPLASH_DISPLAY_LENGHT);
	}	
}
