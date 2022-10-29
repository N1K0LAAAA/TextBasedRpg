public class ViewController
{

    Dictionary<string, View> views;
   

    public ViewController()
    {
        this.views = new Dictionary<string, View>();
    }
     
    public void display(string viewName)
    {
        views[viewName.ToLower()].display(this);
    }

    public void addView(string viewName, View view)
    {
        this.views.Add(viewName.ToLower(), view);
    }
    
    
}
