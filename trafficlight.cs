// initalising all the leds to respective Digital pins
int green = D3;
int yellow = D4;
int red = D5;

void setup() {
// initalising all output pins
  pinMode(red, OUTPUT);
  pinMode(yellow, OUTPUT);
  pinMode(green, OUTPUT);
  
  // function while will be run; the arguments are filled based on "args" in the html code
  int blink = Particle.function("led_colour", led_colour);
}

// function which switches the colour of the led based on the button pressed on the website
int led_colour(String command) {
  if (command == "red") { // turn on red, but other leds off
    digitalWrite(red, HIGH);
    digitalWrite(yellow, LOW);
    digitalWrite(green, LOW);
    return 3;
  } else if (command == "yellow") { // turn on yellow, but other leds off
    digitalWrite(red, LOW);
    digitalWrite(yellow, HIGH);
    digitalWrite(green, LOW);
    return 2;
  } else if (command == "green") { // turn on green, but other leds off
    digitalWrite(red, LOW);
    digitalWrite(yellow, LOW);
    digitalWrite(green, HIGH);
    return 1;
  }
  return -1; 
}

void loop() {
  // nothing will be run here
}
