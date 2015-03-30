package com.example.healthclock;

import java.util.Calendar;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.MotionEvent;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.View.OnTouchListener;
import android.view.Window;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.TimePicker;

public class SelectActivity extends Activity {
	Button btn_dt_select;
	DatePicker datePicker;
	TimePicker timePicker;	

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO 自动生成的方法存根
		super.onCreate(savedInstanceState);
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		setContentView(R.layout.select_main);				
		
		btn_dt_select = (Button) findViewById(R.id.btn_dt_select);
		datePicker = (DatePicker) findViewById(R.id.dpPicker);
		timePicker = (TimePicker) findViewById(R.id.tpPicker);
		timePicker.setIs24HourView(true);				
		
		//显示查询界面
		btn_dt_select.setTypeface(LogoActivity.typeface);
		btn_dt_select.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO 自动生成的方法存根
				Calendar calendar = Calendar.getInstance();
				calendar.set(datePicker.getYear(), datePicker.getMonth(), datePicker.getDayOfMonth(), timePicker.getCurrentHour(), timePicker.getCurrentMinute());				
				Intent intent = new Intent(SelectActivity.this, ShowSelectActivity.class);
				intent.putExtra("calendar", calendar);
				startActivity(intent);
				finish();
			}
		});
		btn_dt_select.setOnTouchListener(new OnTouchListener() {
			
			@Override
			public boolean onTouch(View v, MotionEvent event) {
				// TODO 自动生成的方法存根
	            if(event.getAction()==MotionEvent.ACTION_DOWN){  
	                v.setBackgroundResource(R.drawable.btn_contacts_youni_pressed);  
	            }else if(event.getAction()==MotionEvent.ACTION_UP){  
	                v.setBackgroundResource(R.drawable.btn_contacts_youni_normal);  
	            }
				return false;
			}
		});						
	}

}
