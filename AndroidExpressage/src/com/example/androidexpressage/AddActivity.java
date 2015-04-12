/*
 * ��Ӳ�ѯ��ݽ���
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
	
	String result = "";	//��ѯ���
	String kdID = "";	//���ID
	String kdname = "";	//��ݹ�˾
	String kdnum = "";	//�˵���
	
	HttpURLConnection urlConnection = null;
	URL url = null;
	
	SQLiteDatabase database = null;
	@Override
	public boolean onKeyDown(int keyCode, KeyEvent event) {
		// TODO �Զ����ɵķ������
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
		// TODO �Զ����ɵķ������
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
	        cur = database.rawQuery("select ���ID from KD where ������� = '" + ChooseKDActivity.ChooseKD + "'", null);
	        if (cur != null) {	    
	        	if (cur.moveToFirst()) {
	        		kdID = cur.getString(cur.getColumnIndex("���ID"));
	        	}
	        }
		}
		
		btn_select.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO �Զ����ɵķ������
				kdname = txt_kd.getText().toString();
				kdnum = edit_num.getText().toString();
				if (!kdname.equals("") && !kdnum.equals("")) {
					new Thread(runnable).start();
					dialog.show();
				}else if (kdname.equals("")) {
					Toast.makeText(AddActivity.this, "��ѡ���ݣ�", Toast.LENGTH_SHORT).show();
				}else if (kdnum.equals("")) {
					Toast.makeText(AddActivity.this, "�����뵥�ţ�", Toast.LENGTH_SHORT).show();
				}															
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
		
		btn_kd.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO �Զ����ɵķ������
				Intent intent = new Intent(AddActivity.this, ChooseKDActivity.class);
				startActivity(intent);				
			}
		});
		
		btn_kd.setOnTouchListener(new OnTouchListener() {
			
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
		
		//����������
		btn_return.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO �Զ����ɵķ������
				Intent intent = new Intent(AddActivity.this, MainActivity.class);
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
	}
		
	//ͨ��Url���������߳�
	Runnable runnable = new Runnable() {
		Message msg = new Message();
		@Override
		public void run() {
			// TODO �Զ����ɵķ������
			UrlSelectKd();
		}
	};
	
	/*
	 * ͨ��Url��ѯ���
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
			            
            //��ת����ʾ��������ҳ��
            if (!result.equals("")) {
            	String jsonObject = new JSONObject(result).getString("message");
        		System.out.println(jsonObject);
        		if (jsonObject.equals("ok")) {
    				Intent intent = new Intent(AddActivity.this, ShowActivity.class);
    				intent.putExtra("kd", result);	//���ݶ�������
    				intent.putExtra("kdname", kdname);	//�����
    				intent.putExtra("kdnum", kdnum);	//����        				
    				startActivity(intent);
    				dialog.dismiss();
    				finish();		
    			}else {
					//��������Ϣ�򵥺�������������д��    				
    				Intent intent = new Intent(AddActivity.this, ErrorActivity.class);
    				startActivity(intent);
    				dialog.dismiss();    				
				}
			}            
        } catch (MalformedURLException e) {  
            Log.e("�쳣", e.getMessage());        	
        } catch (IOException e) {  
        	Log.e("�쳣", e.getMessage());  
        } catch (JSONException e) {
			// TODO �Զ����ɵ� catch ��
			e.printStackTrace();
		} finally {  
            urlConnection.disconnect();  
        } 
	}
	
	//��������ת�����ַ���
    private static String readInStream(InputStream inputStream) {
		// TODO Auto-generated method stub
        Scanner scanner = new Scanner(inputStream).useDelimiter("\\A");  
        return scanner.hasNext() ? scanner.next() : "";
	}
}
