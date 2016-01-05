package md54aebfbd4515b6c534d3f4142f38ebff5;


public class MainActivity_WebPlugin
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("WebService.MainActivity/WebPlugin, WebService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainActivity_WebPlugin.class, __md_methods);
	}


	public MainActivity_WebPlugin () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MainActivity_WebPlugin.class)
			mono.android.TypeManager.Activate ("WebService.MainActivity/WebPlugin, WebService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public MainActivity_WebPlugin (md54aebfbd4515b6c534d3f4142f38ebff5.MainActivity p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == MainActivity_WebPlugin.class)
			mono.android.TypeManager.Activate ("WebService.MainActivity/WebPlugin, WebService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "WebService.MainActivity, WebService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
