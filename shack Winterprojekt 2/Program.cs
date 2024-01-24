using Raylib_cs;
using System.ComponentModel.Design;
using System.Numerics;


Raylib.InitWindow(1000, 800, "Hello");
Raylib.SetTargetFPS(60);




Vkung Vkung= new Vkung();          // V står för vita pjäser. t.ex Vkung står för vit kung.
Vdrottning Vdrottning = new Vdrottning(); 
Vtorn[] Vts;
Vhäst[] Vhs;
Vknäkt[] Vkns;
Vbonde[] Vbs;


 
Skung Skung = new Skung();                       // S står för svarta pjäser. t.ex Skung står för svart kung.
Sdrottning Sdrottning = new Sdrottning();
Storn[] Sts;
Shäst[] Shs;
Sknäkt[] Skns;
Sbonde[] Sbs;


Vkns = new Vknäkt[2]; 
 Vhs = new Vhäst[2];  
  
 Vts = new Vtorn[2];
 Vbs = new Vbonde[8];

 Skns = new Sknäkt[2];
 Shs = new Shäst[2];
 Sts = new Storn[2];
 Sbs = new Sbonde[8];


Skns[0] = new Sknäkt();
Skns[1] = new Sknäkt();

Shs[0] = new Shäst();
Shs[1] = new Shäst();

Sts[0] = new Storn();
Sts[1] = new Storn();
for (int i = 0; i < 8; i++)
{
    //Sbs[i] = new Sbonde();
}
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
// for (int r = 0; r < 8; r++)
// {
//     Vbs[r] = new Vbonde(); 
    
// }

//-----------------------------------------------------------------------------------------------------------

 while (!Raylib.WindowShouldClose())
{


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
      
    
  
 
 
 Skung.display();
 Sdrottning.display();
  
  Skns[0].display0();
  Skns[1].display1();
  
  Shs[0].display0();
  Shs[1].display1();
  
  Sts[0].display0();
  Sts[1].display1();
  
  Sbs[0].display0();
  Sbs[1].display1();
  Sbs[2].display2();
  Sbs[3].display3();
  Sbs[4].display4();
  Sbs[5].display5();
  Sbs[6].display6();
  Sbs[7].display7();
  
  
  
  Vkung.display();
  Vdrottning.display();
  
   Vkns[0].display0();
   Vkns[1].display1();
  
   Vhs[0].display0();
   Vhs[1].display1();
  
  Vts[0].display0();
   Vts[1].display1();
  
  Vbs[0].display0();
  Vbs[1].display1();
  Vbs[2].display2();
  Vbs[3].display3();
  Vbs[4].display4();
  Vbs[5].display5();
  Vbs[6].display6();
  Vbs[7].display7();
bool placerad=true;
if ((Raylib.GetMouseX() < Vkung.x + 38 && Raylib.GetMouseX() > Vkung.x ) && (Raylib.GetMouseY() < Vkung.y + 78 && Raylib.GetMouseY() > Vkung.y )&&placerad){
        
    if (Raylib.IsMouseButtonDown(MouseButton.Left)){
      Vkung.x = Raylib.GetMouseX() -19;
       Vkung.y = Raylib.GetMouseY() - 30;
       Vkung.display();
       placerad=false;
    }
    
if ((Skung.x < Vkung.x + 50 && Skung.x > Vkung.x-25 ) && (Skung.y < Vkung.y + 75 && Skung.y > Vkung.y - 25 )&& placerad)        // kollar så att vita hästens hitbox koliderar med svarta kungens hitbox, samt att 
    {                                                                //pjäsen är placerad innan kungen blir tagen och skickas till sidobrädet 
        Skung.x= 825;
        Skung.y= 20;
         // bool dead;
    // if (dead){
    //     gameover
    //     vitt parti vann
    // }
    }

      }


   if ((Raylib.GetMouseX() < Vhs[0].x0 + 50 && Raylib.GetMouseX() > Vhs[0].x0-25 ) && (Raylib.GetMouseY() < Vhs[0].y0 + 75 && Raylib.GetMouseY() > Vhs[0].y0 )&&(placerad)){
        
    if (Raylib.IsMouseButtonDown(MouseButton.Left)){
      Vhs[0].x0 = Raylib.GetMouseX() -19;
       Vhs[0].y0 = Raylib.GetMouseY() - 30;
       Vhs[0].display0();
       placerad=false;
    }           
    
if ((Skung.x < Vhs[0].x0+50 && Skung.x > Vhs[0].x0-25) &&
    (Skung.y < Vhs[0].y0+75 && Skung.y > Vhs[0].y0-25)&& placerad)// kollar så att vita hästens hitbox koliderar med svarta kungens hitbox, samt 
    {                                                             // att pjäsen är placerad innan kungen blir tagen och skickas till sidobrädet 
        Skung.x= 825;
        Skung.y= 20;
         // bool dead;
    // if (dead){
    //     gameover
    //     vitt parti vann
    // }
    }

      }

  
//   //Ifall Vhs[0](vit häst 1) anfaller en Sbs(svart bonde) så ska svarta bonden hamna brevid schackbrädet
   
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

bool placerad1=true;
int pjäsX = Raylib.GetMouseX(); int pjäsY = Raylib.GetMouseY();
for (int alla_pjäser = 0; alla_pjäser <= 12; alla_pjäser++)
{
    
    for (int q = 0; q < 1; q++)
    {
         if ((Raylib.GetMouseX() < Vhs[q].x0 + 50 && Raylib.GetMouseX() > Vhs[q].x0-25 ) && (Raylib.GetMouseY() < Vhs[q].y0 + 75 && Raylib.GetMouseY() > Vhs[0].y0 - 25 )&&(placerad)){
        placerad1=true;
    if (Raylib.IsMouseButtonDown(MouseButton.Left)){
      Vhs[q].x0 = Raylib.GetMouseX() -19;
       Vhs[q].y0 = Raylib.GetMouseY() - 30;
       placerad1=false;
    
    
if ((Skung.x < Vhs[q].x0+50 && Skung.x > Vhs[q].x0-25) &&
    (Skung.y < Vhs[0].y0+75 && Skung.y > Vhs[0].y0-25)&& placerad1)        // kollar så att vita hästens hitbox koliderar med svarta kungens hitbox, samt att 
    {                                                                //pjäsen är placerad innan kungen blir tagen och skickas till sidobrädet 
        Skung.x= 825;
        Skung.y= 20;
         // bool dead;
    // if (dead){
    //     gameover
    //     vitt parti vann
    // }
    }
    }
      }
    }
}



// if ((Raylib.GetMouseX() < Vhs[0].x0 + 50 && Raylib.GetMouseX() > Vhs[0].x0-25 ) && (Raylib.GetMouseY() < Vhs[0].y0 + 75 && Raylib.GetMouseY() > Vhs[0].y0 - 25 )){
        
//     if (Raylib.IsMouseButtonDown(MouseButton.Left)){
//       Vhs[0].x0 = Raylib.GetMouseX() -19;
//        Vhs[0].y0 = Raylib.GetMouseY() - 30;
//        placerad=false;
//     }
    
// if (Raylib.CheckCollisionRecs(VhRec, VhRec)&& placerad)        // kollar så att vita hästens hitbox koliderar med svarta kungens hitbox, samt att 
//     {                                                                //pjäsen är placerad innan kungen blir tagen och skickas till sidobrädet 
//         Skung.x= 825;
//         Skung.y= 20;
//          // bool dead;
//     // if (dead){
//     //     gameover
//     //     vitt parti vann
//     // }
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
