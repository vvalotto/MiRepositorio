class Deduccion(object):
    """Definicion de la Deduccion """
    def __init__(self, porcentaje=0.0):
        self.__descripcion = 'Porcentaje de deduccion'
        self.__porcentaje = porcentaje
        
    def CalcularDeduccion(self,importe):
        """ Es el valor de la alicuota por el valor que se le indica en el calculo"""
        return importe * (self.__porcentaje/100)

    def getPorcentaje(self):
        return self.__porcentaje
    
    def setAlicuota(self, valor):
        self.__porcentaje = valor