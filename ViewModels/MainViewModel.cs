using ExamWPF.Contexts;
using ExamWPF.Core;
using ExamWPF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExamWPF.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Order> Orders { get; set; }
        private readonly OrderContext _context = new OrderContext(@"Data Source = DBSRV\ag2022; Initial Catalog = GomaskoDP_exam; Integrated Security = True");

        private Order? selectedOrder;
        public Order? SelectedOrder
        {
            get
            {
                return selectedOrder;
            }
            set
            {
                selectedOrder = value;
                OnPropertyChanged();
            }
        }
        public ICommand Click { 
            get 
            {
                return new ActionCommand(()=> { 
                    Trace.WriteLine(SelectedOrder.products.Count); 
                    OnPropertyChanged();
                });
            } 
        }

        public MainViewModel()
        {
            _context.Database.EnsureCreated();
            _context.store_order.Load();
            _context.product.Load();
            _context.products_in_order.Load();
            Orders = _context.store_order.Local.ToObservableCollection();
        
        }

    }
}
