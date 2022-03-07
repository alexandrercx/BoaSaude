//using Domain.Interfaces;
//using Domain.Interfaces.Uow;
//using Infrastructure.Context;
//using Infrastructure.Repository;
//using Microsoft.EntityFrameworkCore.Storage;
//using System;
//using System.Threading.Tasks;

//namespace Infrastructure.Uow
//{
//    public class UnitOfWork : IUnitOfWork
//    {
//        private readonly Contexto _contexto;
//        IAssociadoRepository _associadoRepository;
//        IPlanoRepository _planoRepository;
//        IPlanoFaixaEtariaRepository _planoFaixaEtariaRepository;
//        IAssociadoPlanoRepository _associadoPlanoRepository;
//        IEnderecoRepository _enderecoRepository;
//        ITelefoneRepository _telefoneRepository;
//        IContaBancoRepository _contaBancoRepository;
//        public UnitOfWork(Contexto contexto)
//        {
//            _contexto = contexto;
//        }
//        public IAssociadoRepository associadoRepository
//        {
//            get
//            {
//                if (_associadoRepository == null)
//                    _associadoRepository = new AssociadoRepository(_contexto);

//                return _associadoRepository;
//            }
//        }

//        public IPlanoRepository planoRepository
//        {
//            get
//            {
//                if (_planoRepository == null)
//                    _planoRepository = new PlanoRepository(_contexto);

//                return _planoRepository;
//            }
//        }

//        public IPlanoFaixaEtariaRepository planoFaixaEtariaRepository
//        {
//            get
//            {
//                if (_planoFaixaEtariaRepository == null)
//                    _planoFaixaEtariaRepository = new PlanoFaixaEtariaRepository(_contexto);

//                return _planoFaixaEtariaRepository;
//            }
//        }

//        public IAssociadoPlanoRepository associadoPlanoRepository
//        {
//            get
//            {
//                if (_associadoPlanoRepository == null)
//                    _associadoPlanoRepository = new AssociadoPlanoRepository(_contexto);

//                return _associadoPlanoRepository;
//            }
//        }

//        public IEnderecoRepository enderecoRepository
//        {
//            get
//            {
//                if (_enderecoRepository == null)
//                    _enderecoRepository = new EnderecoRepository(_contexto);

//                return _enderecoRepository;
//            }
//        }

//        public ITelefoneRepository _telefoneRepository => throw new NotImplementedException();

//        public IContaBancoRepository _contaBancoRepository => throw new NotImplementedException();

//        public Task<IDbContextTransaction> BeginTran()
//        {
//            throw new NotImplementedException();
//        }

//        public Task Commit()
//        {
//            throw new NotImplementedException();
//        }

//        public Task Rollback()
//        {
//            throw new NotImplementedException();
//        }

//        public Task SaveChanges()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
