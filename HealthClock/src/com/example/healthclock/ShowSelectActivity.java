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
	TextView txt_date;	//��ʾ����
	TextView txt_jiazi;	//��ʾ����
	TextView txt_date_jingluo;	//��ʾ���ھ���
	TextView txt_time;	//��ʾʱ��
	TextView txt_shichen;	//��ʾʱ��
	TextView txt_time_jingluo;	//��ʾʱ�侭��
	TextView txt_lg8f;	//���˷�
	TextView txt_zwlz;	//������ע
	
	TextView txt_title;	//����	
	
	Button btn_return;	//���ذ�ť
	
    String data = "";	//����
    String lunarStr = "";	//����
    String DateJingLuo = "";	//���ھ���
    String time = "";	//ʱ��
    String shichen = "";	//�Ŵ�ʱ��    
    String TimeJingLuo = ""; //ʱ�侭��
    String lg8f = "";	//���˷�
	String zwlz = "";	//������ע
	
    Calendar calendar;	//��ȡ���ڶ���            
    SimpleDateFormat format;
    Lunar lunar;	//��ȡ���������            
    Ancient ancient = new Ancient();	//��ȡ�Ŵ�ʱ�������
    DateJL dateJL = new  DateJL();
    TimeJL timeJL = new TimeJL();
    SelectJL selectJL = new SelectJL();		

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO �Զ����ɵķ������
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
				// TODO �Զ����ɵķ������
				Intent intent = new Intent(ShowSelectActivity.this, SelectActivity.class);
				startActivity(intent);
				finish();
			}
		});
        
        btn_return.setOnTouchListener(new OnTouchListener() {
			
			@Override
			public boolean onTouch(View v, MotionEvent event) {
				// TODO �Զ����ɵķ������
	            if(event.getAction()==MotionEvent.ACTION_DOWN){  
	                v.setBackgroundResource(R.drawable.chat_prev_page_over);  
	            }else if(event.getAction()==MotionEvent.ACTION_UP){  
	                v.setBackgroundResource(R.drawable.chat_prev_page_nor);  
	            }
				return false;
			}
		});
		
		calendar = (Calendar) getIntent().getExtras().get("calendar");
		format = new SimpleDateFormat("yyyy-MM-dd");	//yyyy��MM��dd��  HH:mm
		
		/***************************************������ʾ******************************************/
		
        //��ȡ����
        data = "";
        data = format.format(calendar.getTime());
        
        txt_date.setText(data);
        txt_date.setTypeface(LogoActivity.typeface);
        
        lunar = new Lunar(calendar);
        
        //����ϵͳ���ڻ�ȡ����                         
        lunarStr = "";         
        lunarStr += lunar.cyclical_day();    
          
        txt_jiazi.setText(lunarStr);
        txt_jiazi.setTypeface(LogoActivity.typeface);
        
        //��ȡϵͳʱ��
        time = "";
        format = new SimpleDateFormat ("HH:mm:ss");        
        time = format.format(calendar.getTime());
        
        txt_time.setText(time);
        txt_time.setTypeface(LogoActivity.typeface);
        
        //����ϵͳʱ���ȡ�Ŵ�ʱ��        
        shichen = "";        
        shichen = ancient.convertTime(String.valueOf(calendar.get(Calendar.HOUR_OF_DAY)));
        
        txt_shichen.setText(shichen);
        txt_shichen.setTypeface(LogoActivity.typeface);
        
        //��������ʱ�������Ӧ����
        lg8f = selectJL.getJL(lunarStr.substring(0, 2), shichen.substring(0, 1)).split("#")[0];
        zwlz = selectJL.getJL(lunarStr.substring(0, 2), shichen.substring(0, 1)).split("#")[1];
        
        txt_lg8f.setText(lg8f);
        txt_lg8f.setTypeface(LogoActivity.typeface);        
        txt_zwlz.setText(zwlz);
        txt_zwlz.setTypeface(LogoActivity.typeface);
	}

}
