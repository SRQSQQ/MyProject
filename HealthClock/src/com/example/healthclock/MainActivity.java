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
	TextView txt_date;	//��ʾ����
	TextView txt_jiazi;	//��ʾ����
	TextView txt_date_jingluo;	//��ʾ���ھ���
	TextView txt_time;	//��ʾʱ��
	TextView txt_shichen;	//��ʾʱ��
	TextView txt_time_jingluo;	//��ʾʱ�侭��
	TextView txt_lg8f;	//���˷�
	TextView txt_zwlz;	//������ע
	
	TextView txt_title;	//����
	
	Button btn_acupoint;	//Ѩλͼ��ť
	Button btn_poem;	//����ͼ��ť
	Button btn_select;	//��Ѩ��ѯ��ť
	
    String data = "";	//����
    String lunarStr = "";	//����
    String DateJingLuo = "";	//���ھ���
    String time = "";	//ʱ��
    String shichen = "";	//�Ŵ�ʱ��    
    String TimeJingLuo = ""; //ʱ�侭��
    String lg8f = "";	//���˷�
	String zwlz = "";	//������ע
	
    Calendar calendar;	//��ȡ���ڶ���            
    Lunar lunar;	//��ȡ���������            
    Ancient ancient = new Ancient();	//��ȡ�Ŵ�ʱ�������
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
        
        //��Ѩ��ѯ����
        btn_select.setTypeface(LogoActivity.typeface);
        btn_select.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO �Զ����ɵķ������
				Intent intent = new Intent(MainActivity.this, SelectActivity.class);
				startActivity(intent);
			}
		});
        
        btn_select.setOnTouchListener(new OnTouchListener() {
			
			@Override
			public boolean onTouch(View v, MotionEvent event) {
				// TODO �Զ����ɵķ������
	            if(event.getAction()==MotionEvent.ACTION_DOWN){  
	                v.setBackgroundResource(R.drawable.btn_contacts_youni_pressed);  
	            }else if(event.getAction()==MotionEvent.ACTION_UP){  
	                v.setBackgroundResource(R.drawable.btn_contacts_youni_normal);  
	            }  
				return false;
			}
		});
        
        //Ѩλ��ȫ����
        btn_acupoint.setTypeface(LogoActivity.typeface);
        btn_acupoint.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO �Զ����ɵķ������
				Intent intent = new Intent(MainActivity.this, ViewPagerActivity.class);
				startActivity(intent);
			}
		});
        
        btn_acupoint.setOnTouchListener(new OnTouchListener() {
			
			@Override
			public boolean onTouch(View v, MotionEvent event) {
				// TODO �Զ����ɵķ������
	            if(event.getAction()==MotionEvent.ACTION_DOWN){  
	                v.setBackgroundResource(R.drawable.btn_contacts_youni_pressed);  
	            }else if(event.getAction()==MotionEvent.ACTION_UP){  
	                v.setBackgroundResource(R.drawable.btn_contacts_youni_normal);  
	            }  
				return false;
			}
		});
        
        //ʮ����������
        btn_poem.setTypeface(LogoActivity.typeface);                                                                                                   
        btn_poem.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO �Զ����ɵķ������
				Intent intent = new Intent(MainActivity.this, SimpleSampleActivity.class);
				startActivity(intent);
			}
		});
        
        btn_poem.setOnTouchListener(new OnTouchListener() {
			
			@Override
			public boolean onTouch(View v, MotionEvent event) {
				// TODO �Զ����ɵķ������
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
			// TODO �Զ����ɵķ������
			while (true) {		
				try {
					Thread.sleep(1000);
					Message msg = new Message();
					msg.what = msgKey;
					handler.sendMessage(msg);
				} catch (InterruptedException e) {
					// TODO �Զ����ɵ� catch ��
					e.printStackTrace();
				}			
			}
		}    	
    }
    
    
    private Handler handler = new Handler() {

		@Override
		public void handleMessage(Message msg) {
			// TODO �Զ����ɵķ������
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
     * ��ʾ����ʱ��
     */
    public void txtHealthClock () {
    	calendar = Calendar.getInstance();
    	lunar = new Lunar(calendar);
    	
//    	typeface = Typeface.createFromAsset(getAssets(), "fonts/STKAITI.TTF");
    	
        //��ȡϵͳ����
        data = "";
        data = calendar.get(Calendar.YEAR)+ "-" + (calendar.get(Calendar.MONTH) + 1) + "-" + calendar.get(Calendar.DAY_OF_MONTH);
        
        txt_date.setText(data);
        txt_date.setTypeface(LogoActivity.typeface);
        
        //����ϵͳ���ڻ�ȡ����                         
        lunarStr = "";         
        lunarStr += lunar.cyclical_day();    
          
        txt_jiazi.setText(lunarStr);
        txt_jiazi.setTypeface(LogoActivity.typeface);
        
        //�������ڻ�ȡ���ھ���
        DateJingLuo = dateJL.DateJingLuo(lunarStr.substring(0, 1));
        
        txt_date_jingluo.setText(DateJingLuo);
        txt_date_jingluo.setTypeface(LogoActivity.typeface);
        
        //��ȡϵͳʱ��
        time = "";
/*        time = calendar.get(Calendar.HOUR_OF_DAY) + "-" + calendar.get(Calendar.MINUTE) + "-" + calendar.get(Calendar.SECOND);*/
        SimpleDateFormat formatter = new SimpleDateFormat ("HH:mm:ss");
        Date curDate = new Date(System.currentTimeMillis());//��ȡ��ǰʱ��
        time = formatter.format(curDate);
        
        txt_time.setText(time);
        txt_time.setTypeface(LogoActivity.typeface);
        
        //����ϵͳʱ���ȡ�Ŵ�ʱ��        
        shichen = "";        
        shichen = ancient.convertTime(String.valueOf(calendar.get(Calendar.HOUR_OF_DAY)));
        
        txt_shichen.setText(shichen);
        txt_shichen.setTypeface(LogoActivity.typeface);
        
        //����ʱ���ȡʱ�侭��
        TimeJingLuo = timeJL.TimeJingLuo(shichen);
        
        txt_time_jingluo.setText(TimeJingLuo);
        txt_time_jingluo.setTypeface(LogoActivity.typeface);
                
        //��������ʱ�������Ӧ����
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
