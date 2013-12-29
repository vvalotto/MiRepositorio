import Impuestos
import Deducciones
from Impuestos import IVA
from Deducciones import Deduccion

class Factura(object):
    """Clase basica del sistema, representa el documento de la venta"""
        
    def __init__(self, importe):
        self._importeFactura = importe
        self._importeTotal = importe
        
    def CalcularTotal(self):
        iva = IVA()
        deduccion = Deduccion(5.0)
        
        self._importeIVA = iva.CalcularIVA(self._importeFactura)
        self._importeDeduccion = deduccion.CalcularDeduccion(self._importeFactura)
        self._importeTotal = self._importeFactura + self._importeIVA - self._importeDeduccion
        
        return self._importeTotal
        
    def getImporte(self):
        return self._importeTotal