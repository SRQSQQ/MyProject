/*
 * 主界面
 */
package com.example.androidexpressage;

import java.io.BufferedInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.ArrayList;
import java.util.Scanner;

import org.json.JSONException;
import org.json.JSONObject;

import com.example.tool.DBManager;
import com.example.tool.MessageBean;
import com.example.tool.PrivateListingAdapter;
import com.example.widget.ListViewCompat;

import android.support.v7.app.ActionBarActivity;
import android.support.v4.app.Fragment;
import android.app.Dialog;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.os.Message;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuItem;
import android.view.MotionEvent;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.View.OnTouchListener;
import android.view.ViewGroup;
import android.view.Window;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.AdapterView.OnItemClickListener;
import android.widget.ListAdapter;
import android.widget.ListView;

public class MainActivity extends ActionBarActivity implements OnItemClickListener,
OnClickListener, OnTouchListener{
	Button btn_add;		
	ListViewCompat mListView;
	Dialog dialog;
		
	String kdnum = "";
	String kdname = "";
	String result = "";	//查询结果
	String item_kdname = "";	//快递公司
	String item_kdnum = "";	//运单号
	String item_kdID = "";	//快递ID
	
	int x_down = 0;	//mListView选中Item按下时的x坐标
	int x_up = 0;	//mListView选中Item松开时的x坐标
	
	int count = 0;
	
	int position = 0;	//mListView选中项的值

	SQLiteDatabase database = null;
	Cursor cur = null;
	HttpURLConnection urlConnection = null;
	URL url = null;
	
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        setContentView(R.layout.activity_main);

        btn_add = (Button) findViewById(R.id.btn_add);    
        
		View view = View.inflate(this, R.layout.dialog, null);
		dialog = new Dialog(this, R.style.MyDialog);		
		dialog.setContentView(view);
		
		initView();
        
        //添加预查询快递
        btn_add.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO 自动生成的方法存根
				Intent intent = new Intent(MainActivity.this, AddActivity.class);
				startActivity(intent);		
				finish();
			}
		});
        
        btn_add.setOnTouchListener(new OnTouchListener() {
			
			@Override
			public boolean onTouch(View v, MotionEvent event) {
				// TODO 自动生成的方法存根
	            if(event.getAction()==MotionEvent.ACTION_DOWN){  
	                v.setBackgroundResource(R.drawable.icon_list_add_hover);  
	            }else if(event.getAction()==MotionEvent.ACTION_UP){  
	                v.setBackgroundResource(R.drawable.icon_list_add);  
	            }
				return false;
			}
		});
    }
    
    /*
     * 将数据库中保存的快递订单号添加到ListViewCompat中
     */
	private void initView() {		
		mListView = (ListViewCompat) findViewById(R.id.list);
		PrivateListingAdapter mAdapter = new PrivateListingAdapter(this);
		ArrayList<MessageBean> mMessageList = new ArrayList<MessageBean>();			
		
		database = SQLiteDatabase.openOrCreateDatabase(DBManager.DB_PATH + "/" + DBManager.DB_NAME, null);
		cur = database.rawQuery("select 快递单号,快递名称,保存日期 from Save", null);
		for(cur.moveToFirst();!cur.isAfterLast();cur.moveToNext()) {
			MessageBean item = new MessageBean();
			item.iconRes = R.drawable.wechat_icon;
			item.title = cur.getString(cur.getColumnIndex("快递单号"));
			item.msg = cur.getString(cur.getColumnIndex("快递名称"));
			item.time = cur.getString(cur.getColumnIndex("保存日期"));
			System.out.println(item.title + " " + item.msg + " " + item.time);
			mMessageList.add(item);
		}								
		
		mAdapter.setmMessageItems(mMessageList);
		mListView.setAdapter(mAdapter);		
		mListView.setOnTouchListener(this);
	}
    
	@Override
	public boolean onTouch(View v, MotionEvent event) {
		// TODO 自动生成的方法存根
		switch (event.getAction()) {
		case MotionEvent.ACTION_DOWN:
			x_down = (int) event.getX();
			break;
			
		case MotionEvent.ACTION_UP:
			x_up = (int) event.getX();						
			break;
			
		default:
			break;
		}
		System.out.println("---------" + x_up + " " + x_down + " " + (x_up - x_down));
		if ((x_up - x_down) >= 0) {
			try {
				position = ((ListView)v).pointToPosition((int)event.getX(), (int)event.getY());
				ListAdapter mAdapter = mListView.getAdapter();
				MessageBean item = (MessageBean) mAdapter.getItem(position);			
				item_kdname = item.msg;	//快递公司
				item_kdnum = item.title;	//运单号
				database = SQLiteDatabase.openOrCreateDatabase(DBManager.DB_PATH + "/" + DBManager.DB_NAME, null);			
		        cur = database.rawQuery("select 快递ID from KD where 快递名称 = '" + item_kdname + "'", null);
		        if (cur != null) {	    
		        	if (cur.moveToFirst()) {
		        		item_kdID = cur.getString(cur.getColumnIndex("快递ID"));
		        		new Thread(runnable).start();
		        		dialog.show();
		        	}
		        }				
			} catch (Exception e) {
				// TODO: handle exception
				Log.e("异常", Log.getStackTraceString(e));
			}
		}
		return false;
	}


	@Override
	public void onClick(View v) {
		// TODO 自动生成的方法存根
		
	}


	@Override
	public void onItemClick(AdapterView<?> parent, View view, int position,
			long id) {
		// TODO 自动生成的方法存根
		
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
            url = new URL("http://www.kuaidi100.com/query?type=" + item_kdID + "&postid=" + item_kdnum + "");  
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
			            
            //跳转到显示订单详情页面
            if (!result.equals("")) {
            	String jsonObject = new JSONObject(result).getString("message");
        		System.out.println(jsonObject);
        		if (jsonObject.equals("ok")) {
    				Intent intent = new Intent(MainActivity.this, ShowActivity.class);
    				intent.putExtra("kd", result);	//传递订单详情
    				intent.putExtra("kdname", item_kdname);	//快递名
    				intent.putExtra("kdnum", item_kdnum);	//单号    				
    				startActivity(intent);		
    				dialog.dismiss();
    			}else {
					//无物流信息或单号有误！请重新填写！    				
    				Intent intent = new Intent(MainActivity.this, ErrorActivity.class);
    				startActivity(intent);
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
