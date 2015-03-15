/**
 * 功能  天气查询界面
 */
package user;

import java.io.BufferedReader;
import java.io.InputStreamReader;

import com.example.my_app_carmanage.R;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.webkit.WebChromeClient;
import android.webkit.WebView;
import android.webkit.WebViewClient;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class WeatherActivity extends Activity {
	private Button btn_return;	//返回MainActivity
	private Button btn_update;	//设置警报值
	private Button btn_getWea;	//获取天气按钮
	private WebView webView;	//声明WebView组件的对象
	private EditText txt_cityname;		//城市名称文本框
	public String cityname = "";	//城市名
	public String id = "";	//城市id
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.weather_main);		//设置布局文件
		
		webView=(WebView)findViewById(R.id.webView);	//获取WebView组件
		webView.getSettings().setJavaScriptEnabled(true);	//设置JavaScript可用
		webView.setWebChromeClient(new WebChromeClient());	//处理JavaScript对话框
		webView.setWebViewClient(new WebViewClient());	//处理各种通知和请求事件，如果不使用该句代码，将使用内置浏览器访问网页
		webView.loadUrl("http://m.weather.com.cn/m/pn12/weather.htm ");	//设置默认显示的天气预报信息
		webView.setInitialScale(57 * 4);	//放网页内容放大4倍
		
		try {
			txt_cityname = (EditText)findViewById(R.id.txt_cityname);		
			btn_getWea = (Button)findViewById(R.id.btn_getWea);
			btn_getWea.setOnClickListener(new View.OnClickListener() {
				
				@Override
				public void onClick(View v) {
					cityname = txt_cityname.getText().toString();	//获取输入城市
					id = findId(cityname);
					if(null==id||"".equals(id)){
						Toast.makeText(WeatherActivity.this, "在集合中，没有找到对应城市id", 1).show();
					}else{
						System.out.println(id + "T");
						openUrl(id + "T");
					}		
				}
			});			
		} catch (Exception e) {
			// TODO: handle exception
			System.out.println(e.getMessage());
		}
	}
	
	/**
	 * 打开网页的方法
	 */
	private void openUrl(String id) {
		webView.loadUrl("http://m.weather.com.cn/m/pn12/weather.htm?id="+id+" ");	//获取并显示天气预报信息
	}
	
	/**
	 * 根据城市名找到对应的id如果没有则说明在中国气象网不存在该城市
	 * @param cityname
	 * @return
	 */
	private String findId(String cityname){
		if(null==cityname||"".equals(cityname)) 
			return null;
	      try {
	    	  //打开assets文件夹中citycode.txt文件（城市列表）
              InputStreamReader inputReader = new InputStreamReader( getResources().getAssets().open("citycode.txt") ); 
              BufferedReader bufReader = new BufferedReader(inputReader);
              String line="";
              String[] str = new String[2];
              //解析获取输入城市编号
              while((line = bufReader.readLine()) != null){
              	  str = line.split("=");
              	  if(str.length==2&&null!=str[1]&&!"".equals(str[1])&&cityname.equals(str[1])){
              		  //返回对应编号
              		  return str[0];
              	  }
              }
          } catch (Exception e) { 
              e.printStackTrace(); 
              return null;
          }
          return null;
	}
}
