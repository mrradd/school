using System.Collections.Generic;
using Android.Content;
using Android.Widget;
using Android.Graphics;
using Android.Views;

/*******************************************************************************
* ItemContainer *
* 
* Consists of a Linear Layout with 2 edittable text fields within it; one for
* an item name, and one for an item price.
*******************************************************************************/
namespace SCartGo
  {
  public class ItemContainer : LinearLayout
    {
    /** Item name field. */  public EditText etItemName;
    /** Item price field. */ public EditText etItemPrice;

    /** CTOR */
    public ItemContainer(Context context) : base(context)
      {
      TextView tv = new TextView(context);
      etItemName  = new EditText(context);
      etItemPrice = new EditText(context);

      etItemName.SetMinWidth(1000);
      etItemName.SetMaxWidth(1000);
      etItemName.SetMaxLines(1);

      etItemPrice.SetMinWidth(410);
      etItemPrice.SetMaxWidth(410);
      etItemPrice.SetMaxLines(1);

      etItemName.SetHint(Resource.String.etItemNamePlaceHolder);
      etItemPrice.SetHint(Resource.String.etItemPricePlaceHolder);

      etItemName.RequestFocus();

      this.AddView(etItemName);
      this.AddView(etItemPrice);
      }
    }
  }
