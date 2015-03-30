package com.example.healthclock;

import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;

import tool.Ancient;
import tool.DateJL;
import tool.Lunar;
import tool.SelectJL;
import tool.TimeJL;
import android.support.v7.app.ActionBarActivity;
import android.support.v4.app.Fragment;
import android.content.Intent;
import android.os.Bundle;
import android.os.Handler;
import android.os.Message;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuItem;
import android.view.MotionEvent;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.View.OnTouchListener;
import android.view.ViewGroup;
import android.view.Window;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends ActionBarActivity {
	TextView txt_date;	//显示日期
	TextView txt_jiazi;	//显示甲子
	TextView txt_date_jingluo;	//显示日期经络
	TextView txt_time;	//显示时间
	TextView txt_shichen;	//显示时辰
	TextView txt_time_jingluo;	//显示时间经络
	TextView txt_lg8f;	//灵龟八法
	TextView txt_zwlz;	//子午流注
	
	TextView txt_title;	//标题
	
	Button btn_acupoint;	//穴位图按钮
	Button btn_poem;	//正经图按钮
	Button btn_select;	//经穴查询按钮
	
    String data = "";	//日期
    String lunarStr = "";	//甲子
    String DateJingLuo = "";	//日期经络
    String time = "";	//时间
    String shichen = "";	//古代时辰    
    String TimeJingLuo = ""; //时间经络
    String lg8f = "";	//灵龟八法
	String zwlz = "";	//子午流注
	
    Calendar calendar;	//获取日期对象            
    Lunar lunar;	//获取甲子类对象            
    Ancient ancient = new Ancient();	//获取古代时辰类对象
    DateJL dateJL = new  DateJL();
    TimeJL timeJL = new TimeJL();
    SelectJL selectJL = new SelectJL();        
    
    private static final int msgKey = 1;
    
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        setContentView(R.layout.main);
                        
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
                        
        Runnable runnable = new txtRunnable();       
        Thread thread = new Thread(runnable);
        thread.start();
        
        btn_acupoint = (Button) findViewById(R.id.btn_acupoint);
        btn_poem = (Button) findViewById(R.id.btn_poem);
        btn_select = (Button) findViewById(R.id.btn_select);        
        
        //经穴查询界面
        btn_select.setTypeface(LogoActivity.typeface);
        btn_select.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO 自动生成的方法存根
				Intent intent = new Intent(MainActivity.this, SelectActivity.class);
				startActivity(intent);
			}
		});
        
        btn_select.setOnTouchListener(new OnTouchListener() {
			
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
        
        //穴位大全界面
        btn_acupoint.setTypeface(LogoActivity.typeface);
        btn_acupoint.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO 自动生成的方法存根
				Intent intent = new Intent(MainActivity.this, ViewPagerActivity.class);
				startActivity(intent);
			}
		});
        
        btn_acupoint.setOnTouchListener(new OnTouchListener() {
			
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
        
        //十二正经界面
        btn_poem.setTypeface(LogoActivity.typeface);                                                                                                   
        btn_poem.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO 自动生成的方法存根
				Intent intent = new Intent(MainActivity.this, SimpleSampleActivity.class);
				startActivity(intent);
			}
		});
        
        btn_poem.setOnTouchListener(new OnTouchListener() {
			
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

    public class txtRunnable implements Runnable {

		@Override
		public void run() {
			// TODO 自动生成的方法存根
			while (true) {		
				try {
					Thread.sleep(1000);
					Message msg = new Message();
					msg.what = msgKey;
					handler.sendMessage(msg);
				} catch (InterruptedException e) {
					// TODO 自动生成的 catch 块
					e.printStackTrace();
				}			
			}
		}    	
    }
    
    
    private Handler handler = new Handler() {

		@Override
		public void handleMessage(Message msg) {
			// TODO 自动生成的方法存根
			super.handleMessage(msg);
			switch (msg.what) {
			case msgKey:
				txtHealthClock();
				break;

			default:
				break;
			}
		}
    	
    };
    
    /*
     * 显示养生时钟
     */
    public void txtHealthClock () {
    	calendar = Calendar.getInstance();
    	lunar = new Lunar(calendar);
    	
//    	typeface = Typeface.createFromAsset(getAssets(), "fonts/STKAITI.TTF");
    	
        //获取系统日期
        data = "";
        data = calendar.get(Calendar.YEAR)+ "-" + (calendar.get(Calendar.MONTH) + 1) + "-" + calendar.get(Calendar.DAY_OF_MONTH);
        
        txt_date.setText(data);
        txt_date.setTypeface(LogoActivity.typeface);
        
        //根据系统日期获取甲子                         
        lunarStr = "";         
        lunarStr += lunar.cyclical_day();    
          
        txt_jiazi.setText(lunarStr);
        txt_jiazi.setTypeface(LogoActivity.typeface);
        
        //根据日期获取日期经络
        DateJingLuo = dateJL.DateJingLuo(lunarStr.substring(0, 1));
        
        txt_date_jingluo.setText(DateJingLuo);
        txt_date_jingluo.setTypeface(LogoActivity.typeface);
        
        //获取系统时间
        time = "";
/*        time = calendar.get(Calendar.HOUR_OF_DAY) + "-" + calendar.get(Calendar.MINUTE) + "-" + calendar.get(Calendar.SECOND);*/
        SimpleDateFormat formatter = new SimpleDateFormat ("HH:mm:ss");
        Date curDate = new Date(System.currentTimeMillis());//获取当前时间
        time = formatter.format(curDate);
        
        txt_time.setText(time);
        txt_time.setTypeface(LogoActivity.typeface);
        
        //根据系统时间获取古代时辰        
        shichen = "";        
        shichen = ancient.convertTime(String.valueOf(calendar.get(Calendar.HOUR_OF_DAY)));
        
        txt_shichen.setText(shichen);
        txt_shichen.setTypeface(LogoActivity.typeface);
        
        //根据时间获取时间经络
        TimeJingLuo = timeJL.TimeJingLuo(shichen);
        
        txt_time_jingluo.setText(TimeJingLuo);
        txt_time_jingluo.setTypeface(LogoActivity.typeface);
                
        //根据日期时间算出对应经络
        lg8f = selectJL.getJL(lunarStr.substring(0, 2), shichen.substring(0, 1)).split("#")[0];
        zwlz = selectJL.getJL(lunarStr.substring(0, 2), shichen.substring(0, 1)).split("#")[1];
        
        txt_lg8f.setText(lg8f);
        txt_lg8f.setTypeface(LogoActivity.typeface);        
        txt_zwlz.setText(zwlz);
        txt_zwlz.setTypeface(LogoActivity.typeface);
    }
    
    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.main, menu);
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
            View rootView = inflater.inflate(R.layout.fragment_main, container, false);
            return rootView;
        }
    }

}
