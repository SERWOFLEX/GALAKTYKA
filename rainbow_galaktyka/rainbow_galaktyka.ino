#include <FastLED.h>

#define NUM_LEDS 28      /* The amount of pixels/leds you have */
#define DATA_PIN 0       /* The pin your data line is connected to */
#define LED_TYPE WS2812B /* I assume you have WS2812B leds, if not just change it to whatever you have */
#define BRIGHTNESS 100   /* Control the brightness of your leds */
#define SATURATION 255   /* Control the saturation of your leds */

CRGB leds[NUM_LEDS];

void setup() {
  FastLED.addLeds<LED_TYPE, DATA_PIN>(leds, NUM_LEDS);
}

void loop() {
  for (int j = 0; j < 255; j++) {
    for (int i = 0; i < 15; i++) {
      leds[i] = CHSV(i - (j), SATURATION, BRIGHTNESS); /* The higher the value 4 the less fade there is and vice versa */ 
      
    }
    for (int i = 15; i < 28; i++) {
      leds[i] = CHSV(i - (j-100), SATURATION, BRIGHTNESS); /* The higher the value 4 the less fade there is and vice versa */ 
    }
    FastLED.show();
    if(j == 160){
      delay(2000);
    }
    else{
      delay(50);
    }
     /* Change this to your hearts desire, the lower the value the faster your colors move (and vice versa) */
  }
}
