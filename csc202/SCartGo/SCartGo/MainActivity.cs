using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

/*******************************************************************************
* MainActivity *
* 
* Where the magic starts.
*******************************************************************************/
namespace SCartGo
  {
  [Activity(Label = "SCartGo", MainLauncher = true, ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
  public class MainActivity : Activity
    {
    /** Add new item button. */         Button       mBtnAddNewItem;
    /** Add new item button. */         Button       mBtnTotalUp;
    /** Item horizontal layout list. */ LinearLayout mHLItemList;
    /** Total text view. */             TextView     mTVTotal;

    /** List of item containers. */ List<ItemContainer> mItemContainers = new List<ItemContainer>();

    /***************************************************************************
    * OnCreate */
    /** 
    * Xamarin method for creating thi portion of the app.
    ***************************************************************************/
    protected override void OnCreate(Bundle savedInstanceState)
      {
      base.OnCreate(savedInstanceState);

      SetContentView(Resource.Layout.Main);

      mBtnAddNewItem = (Button)FindViewById(Resource.Id.btnNewItem);
      mBtnTotalUp    = (Button)FindViewById(Resource.Id.btnTotalUp);
      mHLItemList    = (LinearLayout)FindViewById(Resource.Id.hlItemList);
      mTVTotal       = (TextView)FindViewById(Resource.Id.tvTotal);
     
      /** Add click event to Add New Item button. */
      mBtnAddNewItem.Click += delegate
        {
        ItemContainer ic = new ItemContainer(this);
        mItemContainers.Add(ic);
        mHLItemList.AddView(ic);
        };

      /** Add click event to Total Up button. */
      mBtnTotalUp.Click += delegate { updateTotal(); };

      updateTotal();

      mBtnAddNewItem.RequestFocus();
      }

    /***************************************************************************
    * updateTotal */
    /** 
    * Goes through all Item Containers and adds up their prices then updates the
    * Total text field.
    ***************************************************************************/
    protected void updateTotal()
      {
      decimal total = 0m;
      for(int i = 0; i < mItemContainers.Count; i++)
        {
        decimal t = 0m;
        if(decimal.TryParse(mItemContainers[i].etItemPrice.Text, out t))
          total += t;
        }

      mTVTotal.Text = total.ToString("C2");      
      }
    }
  }

