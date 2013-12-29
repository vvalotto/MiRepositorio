#Implementacion del Patron Command

class Switch:
    'La clase invocadora'
    def __init__(self,flipUpCmd, flipDownCmd):
        self.__flipUpCommand = flipUpCmd
        self.__flipDownCommand = flipDownCmd
        
    def flipUp(self): 
        self.__flipUpCommand.execute() 
    def flipDown(self): 
        self.__flipDownCommand.execute()
        
class Light:
    'La clase receptora'
    def turnOn(self): 
        print "The light is on" 
    def turnOff(self): 
        print "The light is off"

class Command:
    'La clase abstract command'
    def __init__(self):
        pass
    def execute(self):
        #Override
        pass

class FlipUpCommand(Command):
    'La clase comando para prender la luz'
    def __init__(self, light):
        self.__light = light
    
    def execute(self):
        self.__light.turnOn()

class FlipDownCommand(Command):
    'La clase comando para apagar la luz'
    def __init__(self, light):
        self.__light = light
    
    def execute(self):
        self.__light.turnOff()
        
class LigthSwitch:
    'La clase cliente'
    def __init__(self):
        self.__lamp = Light()
        self.__switchUp = FlipUpCommand(self.__lamp)
        self.__switchDown = FlipDownCommand(self.__lamp)
        self.__switch = Switch(self.__switchUp, self.__switchDown)
    
    def switch(self, cmd):
        cmd = cmd.strip().upper()
        try:
            if cmd == "ON":
                self.__switch.flipUp()
            elif cmd == "OFF":
                self.__switch.flipDown()
            else:
                print "Argument \"ON\" or \"OFF\" is required."
        except Exception, msg: 
           print "Exception occured: %s" % msg
   

            
            