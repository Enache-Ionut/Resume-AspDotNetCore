namespace Resume.Models
{
  public class Article
  {
    public string Title { get; set; }
    public Author Author { get; set; }
    public string Date { get; set; }
    public string ShortDescription { get; set; }
    public string Image { get; set; }
    public string ControllerName { get; set; }
    public string ActionName { get; set; }
  }
}
