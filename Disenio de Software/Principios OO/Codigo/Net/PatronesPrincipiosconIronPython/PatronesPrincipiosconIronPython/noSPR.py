class Factura(object):
    """Clase basica del sistema, representa el documento de la venta"""
        
    def __init__(self, importe):
        self._importeFactura = importe
        self._importeTotal = importe
        
    def CalcularTotal(self, deduccion, alicuotaIVA):
        self._importeDeduccion = (self._importeFactura * deduccion) / 100
        self._importeIVA = self._importeFactura * alicuotaIVA
        self._importeTotal = (self._importeFactura - self._importeDeduccion) + self._importeIVA
        
    def getImporte(self):
        return self._importeTotal