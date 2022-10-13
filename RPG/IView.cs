interface IView
{
    void change(IView View)
    {
        View.display();
    }
    void display();
}