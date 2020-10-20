namespace conversor_dollar {
    class ConversorDeMoeda {
      
        public static double Iof = 6.38;

        public static double DolarParaReal(double quantia, double cotacao) {
            double total = quantia * cotacao;
            return total + total * Iof / 100.00;   
        }

    }
}
