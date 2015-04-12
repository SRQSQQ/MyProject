package com.example.tool;

import java.util.ArrayList;
import java.util.List;

import com.example.androidexpressage.R;
import com.example.tool.SlideView.OnSlideListener;

import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.view.LayoutInflater;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.TextView;

public class PrivateListingAdapter extends BaseAdapter implements
		OnSlideListener {
	SQLiteDatabase database = null;
	Cursor cur = null;
	
	private static final String TAG = "SlideAdapter";

	private Context mContext;
	private LayoutInflater mInflater;

	private List<MessageBean> mMessageItems = new ArrayList<MessageBean>();
	private SlideView mLastSlideViewWithStatusOn;

	public PrivateListingAdapter(Context context) {
		mContext = context;
		mInflater = LayoutInflater.from(mContext);
	}

	public void setmMessageItems(List<MessageBean> mMessageItems) {
		this.mMessageItems = mMessageItems;
	}

	@Override
	public int getCount() {
		if (mMessageItems == null) {
			mMessageItems = new ArrayList<MessageBean>();
		}
		return mMessageItems.size();
	}

	@Override
	public Object getItem(int position) {
		return mMessageItems.get(position);
	}

	@Override
	public long getItemId(int position) {
		return position;
	}

	@Override
	public View getView(final int position, View convertView, ViewGroup parent) {
		ViewHolder holder;
		SlideView slideView = (SlideView) convertView;
		if (slideView == null) {
			View itemView = mInflater.inflate(R.layout.privatelisting_item,
					null);

			slideView = new SlideView(mContext);
			slideView.setContentView(itemView);

			holder = new ViewHolder(slideView);
			slideView.setOnSlideListener(this);
			slideView.setTag(holder);
		} else {
			holder = (ViewHolder) slideView.getTag();
		}
		final MessageBean item = mMessageItems.get(position);
		item.slideView = slideView;
		item.slideView.shrink();

		holder.icon.setImageResource(item.iconRes);
		holder.title.setText(item.title);
		holder.msg.setText(item.msg);
		holder.time.setText(item.time);
		holder.deleteHolder.setOnClickListener(new OnClickListener() {
			@Override
			public void onClick(View v) {
				database = SQLiteDatabase.openOrCreateDatabase(DBManager.DB_PATH + "/" + DBManager.DB_NAME, null);
				database.execSQL("delete from Save where ¿ìµÝµ¥ºÅ = '"+ item.title +"'");
				mMessageItems.remove(position);
				notifyDataSetChanged();
			}
		});

		return slideView;
	}

	private static class ViewHolder {
		public ImageView icon;
		public TextView title;
		public TextView msg;
		public TextView time;
		public ViewGroup deleteHolder;

		ViewHolder(View view) {
			icon = (ImageView) view.findViewById(R.id.icon);
			title = (TextView) view.findViewById(R.id.title);
			msg = (TextView) view.findViewById(R.id.msg);
			time = (TextView) view.findViewById(R.id.time);
			deleteHolder = (ViewGroup) view.findViewById(R.id.holder);
		}
	}

	@Override
	public void onSlide(View view, int status) {
		if (mLastSlideViewWithStatusOn != null
				&& mLastSlideViewWithStatusOn != view) {
			mLastSlideViewWithStatusOn.shrink();
		}

		if (status == SLIDE_STATUS_ON) {
			mLastSlideViewWithStatusOn = (SlideView) view;
		}
	}
}
