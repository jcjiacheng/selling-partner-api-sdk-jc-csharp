/*
 * Selling Partner API for Merchant Fulfillment
 * With the Selling Partner API for Merchant Fulfillment, you can build applications that sellers can use to purchase shipping for non-Prime and Prime orders using Amazon's Buy Shipping Services.
 *
 * OpenAPI spec version: v0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package software.amazon.spapi.models.merchantfulfillment.v0;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import software.amazon.spapi.models.merchantfulfillment.v0.StandardIdForLabel;
/**
 * Custom text for shipping labels.
 */
@Schema(description = "Custom text for shipping labels.")


public class LabelCustomization {
  @SerializedName("CustomTextForLabel")
  private String customTextForLabel = null;

  @SerializedName("StandardIdForLabel")
  private StandardIdForLabel standardIdForLabel = null;

  public LabelCustomization customTextForLabel(String customTextForLabel) {
    this.customTextForLabel = customTextForLabel;
    return this;
  }

   /**
   * Get customTextForLabel
   * @return customTextForLabel
  **/
  @Schema(description = "")
  public String getCustomTextForLabel() {
    return customTextForLabel;
  }

  public void setCustomTextForLabel(String customTextForLabel) {
    this.customTextForLabel = customTextForLabel;
  }

  public LabelCustomization standardIdForLabel(StandardIdForLabel standardIdForLabel) {
    this.standardIdForLabel = standardIdForLabel;
    return this;
  }

   /**
   * Get standardIdForLabel
   * @return standardIdForLabel
  **/
  @Schema(description = "")
  public StandardIdForLabel getStandardIdForLabel() {
    return standardIdForLabel;
  }

  public void setStandardIdForLabel(StandardIdForLabel standardIdForLabel) {
    this.standardIdForLabel = standardIdForLabel;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    LabelCustomization labelCustomization = (LabelCustomization) o;
    return Objects.equals(this.customTextForLabel, labelCustomization.customTextForLabel) &&
        Objects.equals(this.standardIdForLabel, labelCustomization.standardIdForLabel);
  }

  @Override
  public int hashCode() {
    return Objects.hash(customTextForLabel, standardIdForLabel);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class LabelCustomization {\n");
    
    sb.append("    customTextForLabel: ").append(toIndentedString(customTextForLabel)).append("\n");
    sb.append("    standardIdForLabel: ").append(toIndentedString(standardIdForLabel)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}
