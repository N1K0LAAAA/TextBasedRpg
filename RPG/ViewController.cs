public class ViewController
{

    Dictionary<string, View> views;

    public ViewController()
    {
        this.views = new Dictionary<string, View>();
    }
    public View getView(string viewName)
    {
        return views[viewName.ToLower()];
    }

    public void display(string viewName)
    {
        this.getView(viewName).display(this);
    }

    public void addView(string viewName, View view)
    {
        this.views.Add(viewName.ToLower(), view);
    }
}
