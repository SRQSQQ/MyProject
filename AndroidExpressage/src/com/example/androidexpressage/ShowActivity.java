/*
 * ��ʾ�����������
 */
package com.example.androidexpressage;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import com.example.tool.ChildStatusEntity;
import com.example.tool.DBManager;
import com.example.tool.GroupStatusEntity;
import com.example.tool.StatusExpandAdapter;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.util.Log;
import android.view.MotionEvent;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.View.OnTouchListener;
import android.view.Window;
import android.widget.Button;
import android.widget.ExpandableListView;
import android.widget.ExpandableListView.OnGroupClickListener;
import android.widget.TextView;
import android.widget.Toast;

public class ShowActivity extends Activity {
	private ExpandableListView expandlistView;
	private StatusExpandAdapter statusAdapter;
	private Context context;
	TextView time_text;
	Button btn_save;
	
	static int count = 0;	//������
		
	ArrayList<String> L_time = new ArrayList<String>();
	ArrayList<String> L_context = new ArrayList<String>();
	
	SQLiteDatabase database = null;
	Cursor cur = null;
	
	SimpleDateFormat formatter = null;
	Date curDate = null;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO �Զ����ɵķ������
		super.onCreate(savedInstanceState);
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		setContentView(R.layout.show_main);
		
		context = this;
		expandlistView = (ExpandableListView) findViewById(R.id.expandlist);
		time_text = (TextView) findViewById(R.id.time_text);
		btn_save = (Button) findViewById(R.id.btn_save);
						
		formatter = new SimpleDateFormat ("yyyy-MM-dd");
		curDate = new Date(System.currentTimeMillis());
		
		final String kdname = (String) getIntent().getExtras().get("kdname");
		final String kdnum = (String) getIntent().getExtras().get("kdnum");
		time_text.setText("���ţ�" + kdnum + "\t\t" + kdname);
		
		btn_save.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO �Զ����ɵķ������
				database = SQLiteDatabase.openOrCreateDatabase(DBManager.DB_PATH + "/" + DBManager.DB_NAME, null);
				cur = database.rawQuery("select * from Save where ��ݵ��� = '"+ kdnum +"'", null);
				if (cur.isAfterLast()) {
					System.out.println(cur.getCount());
					database.execSQL("insert into Save values(NULL, '"+ kdnum +"', '"+ kdname +"','"+ formatter.format(curDate) +"')");
					Toast.makeText(ShowActivity.this, "���ű���ɹ���", Toast.LENGTH_SHORT).show();
					Intent intent = new Intent(ShowActivity.this, MainActivity.class);
					startActivity(intent);
					finish();
				}else {				
					Toast.makeText(ShowActivity.this, "�����Ѿ����棬�����ظ����棡", Toast.LENGTH_SHORT).show();
				}				
			}
		});
		
		btn_save.setOnTouchListener(new OnTouchListener() {
			
			@Override
			public boolean onTouch(View v, MotionEvent event) {
				// TODO �Զ����ɵķ������
	            if(event.getAction()==MotionEvent.ACTION_DOWN){  
	                v.setBackgroundResource(R.color.btn_Color_two);  
	            }else if(event.getAction()==MotionEvent.ACTION_UP){  
	                v.setBackgroundResource(R.color.btn_Color_one);  
	            }
				return false;
			}
		});
		
		String json = (String) getIntent().getExtras().get("kd");
		MyJson(json);
		
		initExpandListView();
	}
	
	/**
	 * ��ʼ������չ�б�
	 */
	private void initExpandListView() {
		statusAdapter = new StatusExpandAdapter(context, getListData());
		expandlistView.setAdapter(statusAdapter);
		expandlistView.setGroupIndicator(null); // ȥ��Ĭ�ϴ��ļ�ͷ
		expandlistView.setSelection(0);// ����Ĭ��ѡ����

		// ��������group,�����������ó�Ĭ��չ��
		int groupCount = expandlistView.getCount();
		for (int i = 0; i < groupCount; i++) {
			expandlistView.expandGroup(i);
		}

		expandlistView.setOnGroupClickListener(new OnGroupClickListener() {

			@Override
			public boolean onGroupClick(ExpandableListView parent, View v,
					int groupPosition, long id) {
				// TODO Auto-generated method stub
				return true;
			}
		});
	}
	
	private List<GroupStatusEntity> getListData() {
		List<GroupStatusEntity> groupList;
		ArrayList<String> strArray = new ArrayList<String>();
		ArrayList<String> childTimeArray = new ArrayList<String>();
		for (int i = 0; i < count + 1; i++) {
			strArray.add(L_time.get(i));
			childTimeArray.add(L_context.get(i));
		}
		groupList = new ArrayList<GroupStatusEntity>();
		for (int i = 0; i < strArray.size(); i++) {
			GroupStatusEntity groupStatusEntity = new GroupStatusEntity();
			groupStatusEntity.setGroupName(strArray.get(i));

			List<ChildStatusEntity> childList = new ArrayList<ChildStatusEntity>();

			
			ChildStatusEntity childStatusEntity = new ChildStatusEntity();
			childStatusEntity.setCompleteTime(childTimeArray.get(i));
			childStatusEntity.setIsfinished(true);
			childList.add(childStatusEntity);		

			groupStatusEntity.setChildList(childList);
			groupList.add(groupStatusEntity);
		}
		return groupList;
	}
	
    public void MyJson(String json) {
    	try {    		    		
    		JSONObject jsonObject = new JSONObject(json);
    		JSONArray jsonArray = jsonObject.getJSONArray("data");
    		for(int i=0;i<jsonArray.length();i++){
    			JSONObject joTemp = (JSONObject)jsonArray.opt(i);
    			L_time.add(joTemp.getString("time"));
    			L_context.add(joTemp.getString("context"));
    			count = i;    			
    		}    		    		
		} catch (JSONException e) {
			// TODO �Զ����ɵ� catch ��
			Log.e("MyJson�쳣", Log.getStackTraceString(e));
		}
    }
}
