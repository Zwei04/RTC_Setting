// Date and time functions using a DS1307 RTC connected via I2C and Wire lib

#include <Wire.h>
#include "RTClib.h"

#define BUFFER_SIZE 20

RTC_DS1307 RTC;

char serial_buffer[BUFFER_SIZE];
int buffer_pos;

void setup () {
    Serial.begin(9600);
    Wire.begin();
    RTC.begin();
    buffer_pos = 0;
}

void loop () {

    if(Serial.available() > 0){
      char incoming_char = Serial.read();

      if(incoming_char == '\n'){
        if(serial_buffer[0] == 'H' && serial_buffer[1] == 'I')
          Serial.println("IH");
      
       else if(serial_buffer[0] == 'T' && serial_buffer[1] == '?'){
         DateTime now = RTC.now();
         char time_str[20];
         sprintf(time_str, "%02d/%02d/%d %02d:%02d:%02d",now.day(), now.month(), now.year(),
         now.hour(), now.minute(), now.second());
         Serial.println(time_str);
       }
       else if(serial_buffer[0] == 'T' && serial_buffer[1] == '^'){
         String time_str = String(serial_buffer);
         int day = time_str.substring(2,4).toInt();
         int month = time_str.substring(4,6).toInt();
         int year = time_str.substring(6,10).toInt();
         int hour = time_str.substring(10,12).toInt();
         int minute = time_str.substring(12,14).toInt();
         int second = time_str.substring(14,16).toInt();
         DateTime set_time = DateTime(year, month, day, hour, minute, second);
         RTC.adjust(set_time);
         Serial.println("Success");
       }
       buffer_pos = 0;
      }
     else if(incoming_char == '\r');

     else{
        if(buffer_pos == BUFFER_SIZE - 1)
          buffer_pos = 0;
        serial_buffer[buffer_pos] = incoming_char;
        buffer_pos++;
     }
    }
}
