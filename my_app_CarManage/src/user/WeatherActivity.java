/**
 * ����  ������ѯ����
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
	private Button btn_return;	//����MainActivity
	private Button btn_update;	//���þ���ֵ
	private Button btn_getWea;	//��ȡ������ť
	private WebView webView;	//����WebView����Ķ���
	private EditText txt_cityname;		//���������ı���
	public String cityname = "";	//������
	public String id = "";	//����id
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.weather_main);		//���ò����ļ�
		
		webView=(WebView)findViewById(R.id.webView);	//��ȡWebView���
		webView.getSettings().setJavaScriptEnabled(true);	//����JavaScript����
		webView.setWebChromeClient(new WebChromeClient());	//����JavaScript�Ի���
		webView.setWebViewClient(new WebViewClient());	//�������֪ͨ�������¼��������ʹ�øþ���룬��ʹ�����������������ҳ
		webView.loadUrl("http://m.weather.com.cn/m/pn12/weather.htm ");	//����Ĭ����ʾ������Ԥ����Ϣ
		webView.setInitialScale(57 * 4);	//����ҳ���ݷŴ�4��
		
		try {
			txt_cityname = (EditText)findViewById(R.id.txt_cityname);		
			btn_getWea = (Button)findViewById(R.id.btn_getWea);
			btn_getWea.setOnClickListener(new View.OnClickListener() {
				
				@Override
				public void onClick(View v) {
					cityname = txt_cityname.getText().toString();	//��ȡ�������
					id = findId(cityname);
					if(null==id||"".equals(id)){
						Toast.makeText(WeatherActivity.this, "�ڼ����У�û���ҵ���Ӧ����id", 1).show();
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
	 * ����ҳ�ķ���
	 */
	private void openUrl(String id) {
		webView.loadUrl("http://m.weather.com.cn/m/pn12/weather.htm?id="+id+" ");	//��ȡ����ʾ����Ԥ����Ϣ
	}
	
	/**
	 * ���ݳ������ҵ���Ӧ��id���û����˵�����й������������ڸó���
	 * @param cityname
	 * @return
	 */
	private String findId(String cityname){
		if(null==cityname||"".equals(cityname)) 
			return null;
	      try {
	    	  //��assets�ļ�����citycode.txt�ļ��������б�
              InputStreamReader inputReader = new InputStreamReader( getResources().getAssets().open("citycode.txt") ); 
              BufferedReader bufReader = new BufferedReader(inputReader);
              String line="";
              String[] str = new String[2];
              //������ȡ������б��
              while((line = bufReader.readLine()) != null){
              	  str = line.split("=");
              	  if(str.length==2&&null!=str[1]&&!"".equals(str[1])&&cityname.equals(str[1])){
              		  //���ض�Ӧ���
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
