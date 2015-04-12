/*
 * 错误界面
 */
package com.example.androidexpressage;

import android.app.Activity;
import android.os.Bundle;
import android.view.Window;

public class ErrorActivity extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO 自动生成的方法存根
		super.onCreate(savedInstanceState);
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		setContentView(R.layout.error_main);
	}

}
