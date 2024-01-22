using Raylib_cs;

class Vkung{
  float x;
  float y;
  void display(float tempX, float tempY){
     x = tempX;
     y = tempY;
    // imageMode(CENTER);
    // image(imgvku,x,y);
  }
}

class Vdrottning{
    float x;
    float y;
  void display(float tempX, float tempY){
    x = tempX;
    y = tempY;
    // imageMode(CENTER);
    // image(imgvd,x,y);
  }
}
class Vknäkt{
  float x;
  float y;
  void display(float tempX, float tempY){
    x = tempX;
    y = tempY;
    // imageMode(CENTER);
    // image(imgvkn,x,y);
  }
}

class Vhäst{
  float x0 = 150;
  float y0 = 750;
  
  float x1 = 650;
  float y1 = 750;
  void display1(){
    
    // imageMode(CENTER);
    // image(imgvh,x0,y0);
  }
    void display2(){
    
    // imageMode(CENTER);
    // image(imgvh,x1,y1);
  }
  
}

class Vtorn{
  float x;
  float y;
  void display(float tempX, float tempY){
    x = tempX;
    y = tempY;
    // imageMode(CENTER);
    // image(imgvt,x,y);
  }
}

class Vbonde{
  float x0 = 50;  float y0 = 650;
  float x1 = 150; float y1 = 650;
  float x2 = 250; float y2 = 650;
  float x3 = 350; float y3 = 650;
  float x4 = 450; float y4 = 650;
  float x5 = 550; float y5 = 650;
  float x6 = 650; float y6 = 650;
  float x7 = 750; float y7 = 650;
  
  void display0(){
    
    // imageMode(CENTER);
    // image(imgvb,x0,y0);
  }
  
  void display1(){
    
    // imageMode(CENTER);
    // image(imgvb,x1,y1);
  }
  
  void display2(){
    
    // imageMode(CENTER);
    // image(imgvb,x2,y2);
  }
  
  void display3(){
    
    // imageMode(CENTER);
    // image(imgvb,x3,y3);
  }
  
  void display4(){
    
    // imageMode(CENTER);
    // image(imgvb,x4,y4);
  }
  
  void display5(){
    
    // imageMode(CENTER);
    // image(imgvb,x5,y5);
  }
  
  void display6(){
    
    // imageMode(CENTER);
    // image(imgvb,x6,y6);
  }
  
  void display7(){
    
    // imageMode(CENTER);
    // image(imgvb,x7,y7);
  }
}


public class Skung{
  int x;
  int y;
  public void display(int tempX, int tempY){
    x = tempX;
    y = tempY;
    Texture2D imgsku= Raylib.LoadTexture ("C:/Users/elias.saarenala/programmering med Micke/shack Winterprojekt 2 test/shack Winterprojekt 2 test/svart_bonde.png");
    Rectangle skuRec = new Rectangle(x, y, imgsku.Width, imgsku.Height);
        Raylib.DrawTexture(imgsku, (int)x, (int)y, Color.White);
  }
}

class Sdrottning{
  float x;
  float y;
  void display(float tempX, float tempY){
    x = tempX;
    y = tempY;
    // imageMode(CENTER);
    // image(imgsd,x,y);
  }
}

class Sknäkt{
  float x;
  float y;
  void display(float tempX, float tempY){
    x = tempX;
    y = tempY;
    // imageMode(CENTER);
    // image(imgskn,x,y);
  }
}

class Shäst{
  float x;
  float y;
  
  void display(float tempX, float tempY){
    x = tempX;
    y = tempY;
    // imageMode(CENTER);
    // image(imgsh,x,y);
  }
}

class Storn{
  float x;
  float y;
  void display(float tempX, float tempY){
    x = tempX;
    y = tempY;
    // imageMode(CENTER);
    // image(imgst,x,y);
  }
}

class Sbonde{
  float x0 = 50;  float y0 = 150;
  float x1 = 150; float y1 = 150;
  float x2 = 250; float y2 = 150;
  float x3 = 350; float y3 = 150;
  float x4 = 450; float y4 = 150;
  float x5 = 550; float y5 = 150;
  float x6 = 650; float y6 = 150;
  float x7 = 750; float y7 = 150;
  public void display0(){
    
    // imageMode(CENTER);
    // image(imgsb,x0,y0);
  }
  
 public void display1(){
    
    // imageMode(CENTER);
    // image(imgsb,x1,y1);
  }
  
 public void display2(){
    
    // imageMode(CENTER);
    // image(imgsb,x2,y2);
  }
  
 public void display3(){
    
    // imageMode(CENTER);
    // image(imgsb,x3,y3);
  }
  
 public void display4(){
    
    // imageMode(CENTER);
    // image(imgsb,x4,y4);
  }
  
 public void display5(){
    
    // imageMode(CENTER);
    // image(imgsb,x5,y5);
  }
  
  public void display6(){
    
    // imageMode(CENTER);
    // image(imgsb,x6,y6);
  }
  
 public void display7(){
    
    // imageMode(CENTER);
    // image(imgsb,x7,y7);
  }
  
}
