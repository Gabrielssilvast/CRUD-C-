namespace projetoVersat
{
    internal class MySqlConnection
    {
        private string bancoServidor;

        public MySqlConnection(string bancoServidor)
        {
            this.bancoServidor = bancoServidor;
        }

        internal MySqlCommand CreateCommand()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}