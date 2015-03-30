package com.example.healthclock;

import java.text.SimpleDateFormat;
import java.util.Calendar;

import tool.Ancient;
import tool.DateJL;
import tool.Lunar;
import tool.SelectJL;
import tool.TimeJL;
import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.MotionEvent;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.View.OnTouchListener;
import android.view.Window;
import android.widget.Button;
import android.widget.TextView;

public class ShowSelectActivity extends Activity {
	TextView txt_date;	//显示日期
	TextView txt_jiazi;	//显示甲子
	TextView txt_date_jingluo;	//显示日期经络
	TextView txt_time;	//显示时间
	TextView txt_shichen;	//显示时辰
	TextView txt_time_jingluo;	//显示时间经络
	TextView txt_lg8f;	//灵龟八法
	TextView txt_zwlz;	//子午流注
	
	TextView txt_title;	//标题	
	
	Button btn_return;	//返回按钮
	
    String data = "";	//日期
    String lunarStr = "";	//甲子
    String DateJingLuo = "";	//日期经络
    String time = "";	//时间
    String shichen = "";	//古代时辰    
    String TimeJingLuo = ""; //时间经络
    String lg8f = "";	//灵龟八法
	String zwlz = "";	//子午流注
	
    Calendar calendar;	//获取日期对象            
    SimpleDateFormat format;
    Lunar lunar;	//获取甲子类对象            
    Ancient ancient = new Ancient();	//获取古代时辰类对象
    DateJL dateJL = new  DateJL();
    TimeJL timeJL = new TimeJL();
    SelectJL selectJL = new SelectJL();		

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO 自动生成的方法存根
		super.onCreate(savedInstanceState);
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		setContentView(R.layout.show_select);				
		
        txt_date = (TextView) findViewById(R.id.txt_date);
        txt_jiazi = (TextView) findViewById(R.id.txt_jiazi);
        txt_date_jingluo = (TextView) findViewById(R.id.txt_date_jingluo);
        txt_time = (TextView) findViewById(R.id.txt_time);
        txt_shichen = (TextView) findViewById(R.id.txt_shichen);
        txt_time_jingluo = (TextView) findViewById(R.id.txt_time_jingluo);
        txt_lg8f = (TextView) findViewById(R.id.txt_lg8f);
        txt_zwlz = (TextView) findViewById(R.id.txt_zwlz);
        
        txt_title = (TextView) findViewById(R.id.txt_title);
        txt_title.setTypeface(LogoActivity.typeface);
        
        btn_return = (Button) findViewById(R.id.btn_return);
        btn_return.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO 自动生成的方法存根
				Intent intent = new Intent(ShowSelectActivity.this, SelectActivity.class);
				startActivity(intent);
				finish();
			}
		});
        
        btn_return.setOnTouchListener(new OnTouchListener() {
			
			@Override
			public boolean onTouch(View v, MotionEvent event) {
				// TODO 自动生成的方法存根
	            if(event.getAction()==MotionEvent.ACTION_DOWN){  
	                v.setBackgroundResource(R.drawable.chat_prev_page_over);  
	            }else if(event.getAction()==MotionEvent.ACTION_UP){  
	                v.setBackgroundResource(R.drawable.chat_prev_page_nor);  
	            }
				return false;
			}
		});
		
		calendar = (Calendar) getIntent().getExtras().get("calendar");
		format = new SimpleDateFormat("yyyy-MM-dd");	//yyyy年MM月dd日  HH:mm
		
		/***************************************设置显示******************************************/
		
        //获取日期
        data = "";
        data = format.format(calendar.getTime());
        
        txt_date.setText(data);
        txt_date.setTypeface(LogoActivity.typeface);
        
        lunar = new Lunar(calendar);
        
        //根据系统日期获取甲子                         
        lunarStr = "";         
        lunarStr += lunar.cyclical_day();    
          
        txt_jiazi.setText(lunarStr);
        txt_jiazi.setTypeface(LogoActivity.typeface);
        
        //获取系统时间
        time = "";
        format = new SimpleDateFormat ("HH:mm:ss");        
        time = format.format(calendar.getTime());
        
        txt_time.setText(time);
        txt_time.setTypeface(LogoActivity.typeface);
        
        //根据系统时间获取古代时辰        
        shichen = "";        
        shichen = ancient.convertTime(String.valueOf(calendar.get(Calendar.HOUR_OF_DAY)));
        
        txt_shichen.setText(shichen);
        txt_shichen.setTypeface(LogoActivity.typeface);
        
        //根据日期时间算出对应经络
        lg8f = selectJL.getJL(lunarStr.substring(0, 2), shichen.substring(0, 1)).split("#")[0];
        zwlz = selectJL.getJL(lunarStr.substring(0, 2), shichen.substring(0, 1)).split("#")[1];
        
        txt_lg8f.setText(lg8f);
        txt_lg8f.setTypeface(LogoActivity.typeface);        
        txt_zwlz.setText(zwlz);
        txt_zwlz.setTypeface(LogoActivity.typeface);
	}

}
