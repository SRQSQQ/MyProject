package com.example.healthclock;

import java.util.Calendar;

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
import android.view.View;
import android.view.View.OnClickListener;
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
	
	Button btn_acupoint;	//Ѩλͼ��ť
	Button btn_poem;	//����ͼ��ť
	
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
                        
        Runnable runnable = new txtRunnable();       
        Thread thread = new Thread(runnable);
        thread.start();
        
        btn_acupoint = (Button) findViewById(R.id.btn_acupoint);
        btn_poem = (Button) findViewById(R.id.btn_poem);
        
        //Ѩλ��ȫ����
        btn_acupoint.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO �Զ����ɵķ������
				Intent intent = new Intent(MainActivity.this, ViewPagerActivity.class);
				startActivity(intent);
			}
		});
        
        //ʮ����������
        btn_poem.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO �Զ����ɵķ������
				Intent intent = new Intent(MainActivity.this, SimpleSampleActivity.class);
				startActivity(intent);
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
    	
        //��ȡϵͳ����
        data = "";
        data = calendar.get(Calendar.YEAR)+ "-" + (calendar.get(Calendar.MONTH) + 1) + "-" + calendar.get(Calendar.DAY_OF_MONTH);
        
        txt_date.setText(data);
        
        //����ϵͳ���ڻ�ȡ����                         
        lunarStr = "";         
        lunarStr += lunar.cyclical() + "��";    
          
        txt_jiazi.setText(lunarStr);
        
        //�������ڻ�ȡ���ھ���
        DateJingLuo = dateJL.DateJingLuo(lunarStr.substring(0, 1));
        
        txt_date_jingluo.setText(DateJingLuo);
        
        //��ȡϵͳʱ��
        time = "";
        time = calendar.get(Calendar.HOUR_OF_DAY) + "-" + calendar.get(Calendar.MINUTE) + "-" + calendar.get(Calendar.SECOND);
        
        txt_time.setText(time);
        
        //����ϵͳʱ���ȡ�Ŵ�ʱ��        
        shichen = "";        
        shichen = ancient.convertTime(String.valueOf(calendar.get(Calendar.HOUR_OF_DAY)));
        
        txt_shichen.setText(shichen);	 
        
        //����ʱ���ȡʱ�侭��
        TimeJingLuo = timeJL.TimeJingLuo(shichen);
        
        txt_time_jingluo.setText(TimeJingLuo);
                
        //��������ʱ�������Ӧ����
        lg8f = "���˷���\t" + selectJL.getJL(lunarStr.substring(0, 2), shichen.substring(0, 1)).split("#")[0];
        zwlz = "������ע��\t" + selectJL.getJL(lunarStr.substring(0, 2), shichen.substring(0, 1)).split("#")[1];
        
        txt_lg8f.setText(lg8f);
        txt_zwlz.setText(zwlz);
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
