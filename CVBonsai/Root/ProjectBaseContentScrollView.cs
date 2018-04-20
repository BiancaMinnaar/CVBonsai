﻿using CVBonsai.Root.ViewController;
using CVBonsai.Root.ViewModel;
using CVBonsai.Trunk.Repository.Implementation;
using Xamarin.Forms;

namespace CVBonsai.Root.View
{
    public abstract class ProjectBaseContentScrollView<T, M> : ScrollView
		where T : ProjectBaseViewController<M>, new()
		where M : ProjectBaseViewModel
	{
		protected T _ViewController;

		protected ProjectBaseContentScrollView()
		{
			_ViewController = new T();
            SetSVGCollection();
			_ViewController._MasterRepo = MasterRepository.MasterRepo;
			_ViewController.SetRepositories();
		}

		protected abstract void SetSVGCollection();
	}
}
