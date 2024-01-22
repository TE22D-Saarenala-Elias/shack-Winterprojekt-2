using Raylib_cs;
using System.ComponentModel.Design;
using System.Numerics;


Raylib.InitWindow(1000, 800, "Hello");
Raylib.SetTargetFPS(60);

Vkung Vku; 
Vdrottning Vd; 
Vknäkt Vkn; Vknäkt[] Vkns;
Vhäst Vh; Vhäst[] Vhs;
Vtorn Vt; Vtorn[] Vts;
Vbonde Vb; Vbonde[] Vbs;

Skung Sku; 
Sdrottning Sd;
Sknäkt Skn; Sknäkt[] Skns;
Shäst Sh; Shäst[] Shs;
Storn St; Storn[] Sts;
Sbonde Sb; Sbonde[] Sbs;

Vkung Vkung= new Vkung();                           // V står för vita pjäser. t.ex Vkung står för vit kung.
Vdrottning Vdrottning = new Vdrottning();


Skung Skung = new Skung();                          // S står för svarta pjäser. t.ex Skung står för svart kung.
Sdrottning Sdrottning = new Sdrottning();


//-----------------------------------------------------------------------------------------------------------

 while (!Raylib.WindowShouldClose())
{

  
// imgskn= Raylib.LoadImage ("C:/Users/elias.saarenala/Desktop/Schack_the_game/image/svart_knäkt.png");
// imgsh = Raylib.LoadImage ("C:/Users/elias.saarenala/Desktop/Schack_the_game/image/svart_häst.png");
// imgst = Raylib.LoadImage ("C:/Users/elias.saarenala/Desktop/Schack_the_game/image/svart_torn.png");
// imgsb = Raylib.LoadImage ("C:/Users/elias.saarenala/Desktop/Schack_the_game/image/svart_bonde.png");

// imgvku= Raylib.LoadImage ("C:/Users/elias.saarenala/Desktop/Schack_the_game/image/vit_kung.png");
// imgvd = Raylib.LoadImage ("C:/Users/elias.saarenala/Desktop/Schack_the_game/image/vit_drottning.png");
// imgvkn= Raylib.LoadImage ("C:/Users/elias.saarenala/Desktop/Schack_the_game/image/vit_knäkt.png");
// imgvh = Raylib.LoadImage ("C:/Users/elias.saarenala/Desktop/Schack_the_game/image/vit_häst.png");
// imgvt = Raylib.LoadImage ("C:/Users/elias.saarenala/Desktop/Schack_the_game/image/vit_torn.png");
// imgvb = Raylib.LoadImage ("C:/Users/elias.saarenala/Desktop/Schack_the_game/image/vit_bonde.png");

Vku = new Vkung();  
Vd = new Vdrottning(); 
Vkn = new Vknäkt(); Vkns = new Vknäkt[2];
Vh = new Vhäst(); Vhs = new Vhäst[2];
Vt = new Vtorn(); Vts = new Vtorn[2];
Vb = new Vbonde(); Vbs = new Vbonde[8];

Sku = new Skung();
Sd = new Sdrottning(); 
Skn = new Sknäkt(); Skns = new Sknäkt[2];
Sh = new Shäst(); Shs = new Shäst[2];
St = new Storn(); Sts = new Storn[2];
Sb = new Sbonde(); Sbs = new Sbonde[8];


Skns[0] = new Sknäkt();
Skns[1] = new Sknäkt();

Shs[0] = new Shäst();
Shs[1] = new Shäst();

Sts[0] = new Storn();
Sts[1] = new Storn();

Sbs[0] = new Sbonde();
Sbs[1] = new Sbonde();
Sbs[2] = new Sbonde();
Sbs[3] = new Sbonde();
Sbs[4] = new Sbonde();
Sbs[5] = new Sbonde();
Sbs[6] = new Sbonde();
Sbs[7] = new Sbonde();


Vkns[0] = new Vknäkt();
Vkns[1] = new Vknäkt();

Vhs[0] = new Vhäst();
Vhs[1] = new Vhäst();

Vts[0] = new Vtorn();
Vts[1] = new Vtorn();

Vbs[0] = new Vbonde(); 
Vbs[1] = new Vbonde();
Vbs[2] = new Vbonde();
Vbs[3] = new Vbonde();
Vbs[4] = new Vbonde();
Vbs[5] = new Vbonde();
Vbs[6] = new Vbonde();
Vbs[7] = new Vbonde();
// background(255);
// strokeWeight(4);





//-------------------------------------------------------------------------------------------------------------------
//                              RENDERING
//---------------------------------------------------------------------------------------------------------------------

int rigtSide1 = 600;
int rigtSide2 = 700;
int i = 0;

Raylib.BeginDrawing();
for (int x = 0; x < 901; x =x+200){     //--------------------------------------
                     
  Raylib.DrawRectangle(x,i,100,100,Color.Black);                      // x = x-kordinaten för de svarta rutorna
  if (i >= 800) {                       // i = y-kordinaten för de svarta rutorna
    x = 901;
  }
  if (x == rigtSide1) {
     x = -100;                           //funktionen som skappar svarta rutor
     i += 100;
      }
  if (x == rigtSide2) {
     x = -200;
     i += 100;
      }                           //----------------------------------------------
}
                                    //--------------------------------------
     int l = 0;
      for (int z = 100; z < 901; z =z+200){     //funktionen som skappar gröna rutor
    Raylib.DrawRectangle(z,l,100,100,Color.Green);       //z = x-kordinaten för gröna fyrkanten
  if (l >= 800) {
    z = 901;                                   // l = y-kordinaten för gröna fyrkanten
  }
  if (z == rigtSide1+100) {
     z = -200;                           
     l += 100;
      }                                  
  if (z == rigtSide2+100) {
     z = -100;                          
     l += 100;
      }   
      }
      Raylib.DrawRectangle(800,0,1000,800,Color.White);     // Sidobrädet för tagna pjäser
                                   //--------------------------------------------
      
     

  
 
 
   Skung.display(125,20);
//   Sdrottning.display(450,50);
  
//   Skns[0].display(250,50);
//   Skns[1].display(550,50);
  
//   Shs[0].display(150,50);
//   Shs[1].display(650,50);
  
//   Sts[0].display(50,50);
//   Sts[1].display(750,50);
  
//   Sbs[0].display0();
//   Sbs[1].display1();
//   Sbs[2].display2();
//   Sbs[3].display3();
//   Sbs[4].display4();
//   Sbs[5].display5();
//   Sbs[6].display6();
//   Sbs[7].display7();
  
  
  
//   Vkung.display(350,750);
//   Vdrottning.display(450,750);
  
//   Vkns[0].display(250,750);
//   Vkns[1].display(550,750);
  
//   Vhs[0].display1();
//   Vhs[1].display2();
  
//   Vts[0].display(50,750);
//   Vts[1].display(750,750);
  
//   Vbs[0].display0();
//   Vbs[1].display1();
//   Vbs[2].display2();
//   Vbs[3].display3();
//   Vbs[4].display4();
//   Vbs[5].display5();
//   Vbs[6].display6();
//   Vbs[7].display7();
  
//   if (Raylib.CheckCollisionRecs(skuRec, Sbs[0]))
//     {
//       coins++;
//     }
//   //Ifall Vhs[0](vit häst 1) anfaller en Sbs(svart bonde) så ska svarta bonden hamna brevid schackbrädet
//    if ((mouseX < Vhs[0].x0 + 25 && mouseX > Vhs[0].x0 - 25) && (mouseY < Vhs[0].y0 + 50 && mouseY > Vhs[0].y0 - 50 )){

//    if (Raylib.IsMouseButtonDown(MouseButton.Left)){
//      Vhs[0].x0 = mouseX; Vhs[0].y0 = mouseY;
    
//      if((Sbs[0].x0 == Vhs[0].x0) && (Sbs[0].y0 == Vhs[0].y0) ){
//        Sbs[0].x0 = 850; Sbs[0].y0 = 50;
//     }
//     if((Sbs[1].x1 == Vhs[0].x0) && (Sbs[1].y1 == Vhs[0].y0) ){
//       Sbs[1].x1 = 950; Sbs[1].y1 = 50;
//     }
//     if((Sbs[2].x2 == Vhs[0].x0) && (Sbs[2].y2 == Vhs[0].y0) ){
//       Sbs[2].x2 = 850; Sbs[2].y2 = 150;
//     }
//     if((Sbs[3].x3 == Vhs[0].x0) && (Sbs[3].y3 == Vhs[0].y0) ){
//       Sbs[3].x3 = 950; Sbs[3].y3 = 150;
//     }
//     if((Sbs[4].x4 == Vhs[0].x0) && (Sbs[4].y4 == Vhs[0].y0) ){
//       Sbs[4].x4 = 850; Sbs[4].y4 = 250;
//     }
//     if((Sbs[5].x5 == Vhs[0].x0) && (Sbs[5].y5 == Vhs[0].y0) ){
//       Sbs[5].x5 = 950; Sbs[5].y5 = 250;
//     }
//     if((Sbs[6].x6 == Vhs[0].x0) && (Sbs[6].y6 == Vhs[0].y0) ){
//       Sbs[6].x6 = 850; Sbs[6].y6 = 350;
//     }
//     if((Sbs[7].x7 == Vhs[0].x0) && (Sbs[7].y7 == Vhs[0].y0) ){
//       Sbs[7].x7 = 950; Sbs[7].y7 = 350;
//       }
//     }
//   }
  
//    if (Vhs[1].y1 == -50) {
//         Vhs[1].y1 = 150;                              
//         Vhs[1].x1 = 350;                             
//       }
//    if ((mouseX < Vhs[1].x1 + 25 && mouseX > Vhs[1].x1 - 25) && (mouseY < Vhs[1].y1 + 50 && mouseY > Vhs[1].y1 - 50 )){
  
//     if (mousePressed ){
      
//       Vhs[1].x1 -=  100;      // Vhs[1].y1 är y-kordinaten för häst 2
//       Vhs[1].y1 -=  200;      // Vhs[1].x1 är x-kordinaten för häst 2
//   if((Sbs[3].x3 == Vhs[1].x1) && (Sbs[3].y3 == Vhs[1].y1) ){
//       Sbs[3].x3 = 950; Sbs[3].y3 = 150;
      
//   }
//   }
//   }
Raylib.EndDrawing();

}