import Facturacion
from Facturacion import *

#print "Ejemplo de no cumplimiento del SPR"

#unaFactura = Factura(1000)
#print "Importe sin impuestos:"
#print unaFactura.getImporte()
#unaFactura.CalcularTotal(5,0.21)
#print "Importe con impuestos:"
#print unaFactura.getImporte()

print "Ejemplo de cumplimiento del SPR"

unaFactura = Factura(1000)
print "Importe sin impuestos:"
print unaFactura.getImporte()
unaFactura.CalcularTotal()
print "Importe con impuestos:"
print unaFactura.getImporte()

o = raw_input('>')
