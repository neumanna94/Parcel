namespace Parcel.Models
{
  public class MyParcel
  {
    private int _width;
    private int _length;
    private int _height;

    public void SetWidth(string inputWidth){
      _width = int.Parse(inputWidth);
    }
    public void SetLength(string inputLength){
      _length = int.Parse(inputLength);
    }
    public void SetHeight(string inputHeight){
      _height = int.Parse(inputHeight);
    }

    public string GetLength(){
      return _length.ToString();
    }
    public string GetWidth(){
      return _width.ToString();
    }
    public string GetHeight(){
      return _height.ToString();
    }
    public int Volume(){
      return _width*_length*_height;
    }
    public int CostToShip(){
      return this.Volume()*10;
    }
    public string Report(){
      return "Length: " + this.GetLength() +  " Width: " + this.GetWidth() + " Height: " + this.GetHeight() + " Volume: " + this.Volume() + " Cost: " + this.CostToShip();
    }
  }
}
