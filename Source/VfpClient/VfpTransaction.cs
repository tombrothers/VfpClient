using System.Data;
using System.Data.Common;
using System.Data.OleDb;

namespace VfpClient {
    public class VfpTransaction : DbTransaction {
        private readonly VfpConnection _vfpConnection;
        private OleDbTransaction _oleDbTransaction;

        protected override DbConnection DbConnection {
            get { return _vfpConnection; }
        }

        internal OleDbTransaction OleDbTransaction {
            get { return _oleDbTransaction; }
            set { _oleDbTransaction = value; }
        }

        public override IsolationLevel IsolationLevel {
            get { return _oleDbTransaction.IsolationLevel; }
        }

        public VfpTransaction(OleDbTransaction oleDbTransaction, VfpConnection vfpConnection) {
            _oleDbTransaction = oleDbTransaction;
            _vfpConnection = vfpConnection;
        }

        public override void Commit() {
            try {
                _oleDbTransaction.Commit();
            }
            catch (OleDbException e) {
                throw new VfpException(e.Message, e);
            }
        }

        public override void Rollback() {
            try {
                _oleDbTransaction.Rollback();
            }
            catch (OleDbException e) {
                throw new VfpException(e.Message, e);
            }
        }
    }
}