ligthSwitch = LigthSwitch()
a = raw_input('>')    
print "Prueba Switch ON"
ligthSwitch.switch("ON")
  
print "Prueba Switch OFF"
ligthSwitch.switch("OFF")
    
print "Prueba Comando invalids"
ligthSwitch.switch("****")