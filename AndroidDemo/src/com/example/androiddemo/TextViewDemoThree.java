package com.example.androiddemo;

import android.app.Activity;
import android.os.Bundle;
import android.text.method.ScrollingMovementMethod;
import android.widget.TextView;

public class TextViewDemoThree extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO �Զ����ɵķ������
		super.onCreate(savedInstanceState);
		setContentView(R.layout.demo_txt3);
		
		TextView textView = (TextView) findViewById(R.id.txtThree_txt5);
		textView.setMovementMethod(ScrollingMovementMethod.getInstance());
	}

}
