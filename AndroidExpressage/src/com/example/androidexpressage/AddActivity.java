/*
 * 添加查询快递界面
 */
package com.example.androidexpressage;

import java.io.BufferedInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.Scanner;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import com.example.tool.DBManager;

import android.app.Activity;
import android.app.Dialog;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.os.Message;
import android.util.Log;
import android.view.KeyEvent;
import android.view.MotionEvent;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.View.OnTouchListener;
import android.view.Window;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ProgressBar;
import android.widget.TextView;
import android.widget.Toast;

public class AddActivity extends Activity {
	Button btn_return;
	Button btn_kd;
	Button btn_select;
	TextView txt_kd;
	EditText edit_num;
	Dialog dialog;
	
	String result = "";	//查询结果
	String kdID = "";	//快递ID
	String kdname = "";	//快递公司
	String kdnum = "";	//运单号
	
	HttpURLConnection urlConnection = null;
	URL url = null;
	
	SQLiteDatabase database = null;
	@Override
	public boolean onKeyDown(int keyCode, KeyEvent event) {
		// TODO 自动生成的方法存根
		if (keyCode == KeyEvent.KEYCODE_BACK) {
			Intent intent = new Intent(AddActivity.this, MainActivity.class);
			startActivity(intent);
			finish();
		}
		return super.onKeyDown(keyCode, event);
	}

	Cursor cur = null;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO 自动生成的方法存根
		super.onCreate(savedInstanceState);
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		setContentView(R.layout.add_main);				
		
		btn_return = (Button) findViewById(R.id.btn_return);
		btn_kd = (Button) findViewById(R.id.btn_kd);
		btn_select = (Button) findViewById(R.id.btn_select);
		txt_kd = (TextView) findViewById(R.id.txt_kd);
		edit_num = (EditText) findViewById(R.id.edit_num);
		
		View view = View.inflate(this, R.layout.dialog, null);
		dialog = new Dialog(this, R.style.MyDialog);		
		dialog.setContentView(view);
		
		if (!(ChooseKDActivity.ChooseKD.equals(""))) {
			txt_kd.setText(ChooseKDActivity.ChooseKD);
			database = SQLiteDatabase.openOrCreateDatabase(DBManager.DB_PATH + "/" + DBManager.DB_NAME, null);			
	        cur = database.rawQuery("select 快递ID from KD where 快递名称 = '" + ChooseKDActivity.ChooseKD + "'", null);
	        if (cur != null) {	    
	        	if (cur.moveToFirst()) {
	        		kdID = cur.getString(cur.getColumnIndex("快递ID"));
	        	}
	        }
		}
		
		btn_select.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO 自动生成的方法存根
				kdname = txt_kd.getText().toString();
				kdnum = edit_num.getText().toString();
				if (!kdname.equals("") && !kdnum.equals("")) {
					new Thread(runnable).start();
					dialog.show();
				}else if (kdname.equals("")) {
					Toast.makeText(AddActivity.this, "请选择快递！", Toast.LENGTH_SHORT).show();
				}else if (kdnum.equals("")) {
					Toast.makeText(AddActivity.this, "请输入单号！", Toast.LENGTH_SHORT).show();
				}															
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
		
		btn_kd.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO 自动生成的方法存根
				Intent intent = new Intent(AddActivity.this, ChooseKDActivity.class);
				startActivity(intent);				
			}
		});
		
		btn_kd.setOnTouchListener(new OnTouchListener() {
			
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
		
		//返回主界面
		btn_return.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO 自动生成的方法存根
				Intent intent = new Intent(AddActivity.this, MainActivity.class);
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
	}
		
	//通过Url访问网络线程
	Runnable runnable = new Runnable() {
		Message msg = new Message();
		@Override
		public void run() {
			// TODO 自动生成的方法存根
			UrlSelectKd();
		}
	};
	
	/*
	 * 通过Url查询快递
	 */
	public void UrlSelectKd() {
        try {
            url = new URL("http://www.kuaidi100.com/query?type=" + kdID + "&postid=" + kdnum + "");  
            urlConnection = (HttpURLConnection)url.openConnection();
            urlConnection.setRequestMethod("POST");
            urlConnection.setDoInput(true);            
            urlConnection.setRequestProperty("Content-Type", ("application/xml; charset=utf-8").replaceAll("\\s", ""));                        
            InputStream inputStream = null;
            if (urlConnection.getResponseCode() == 200) {  
            	inputStream = new BufferedInputStream(urlConnection.getInputStream());  
            } else {  
            	inputStream = new BufferedInputStream(urlConnection.getErrorStream());  
            }             		
            result = readInStream(inputStream);  
            System.out.println(result);         
			            
            //跳转到显示订单详情页面
            if (!result.equals("")) {
            	String jsonObject = new JSONObject(result).getString("message");
        		System.out.println(jsonObject);
        		if (jsonObject.equals("ok")) {
    				Intent intent = new Intent(AddActivity.this, ShowActivity.class);
    				intent.putExtra("kd", result);	//传递订单详情
    				intent.putExtra("kdname", kdname);	//快递名
    				intent.putExtra("kdnum", kdnum);	//单号        				
    				startActivity(intent);
    				dialog.dismiss();
    				finish();		
    			}else {
					//无物流信息或单号有误！请重新填写！    				
    				Intent intent = new Intent(AddActivity.this, ErrorActivity.class);
    				startActivity(intent);
    				dialog.dismiss();    				
				}
			}            
        } catch (MalformedURLException e) {  
            Log.e("异常", e.getMessage());        	
        } catch (IOException e) {  
        	Log.e("异常", e.getMessage());  
        } catch (JSONException e) {
			// TODO 自动生成的 catch 块
			e.printStackTrace();
		} finally {  
            urlConnection.disconnect();  
        } 
	}
	
	//将数据流转换成字符串
    private static String readInStream(InputStream inputStream) {
		// TODO Auto-generated method stub
        Scanner scanner = new Scanner(inputStream).useDelimiter("\\A");  
        return scanner.hasNext() ? scanner.next() : "";
	}
}
