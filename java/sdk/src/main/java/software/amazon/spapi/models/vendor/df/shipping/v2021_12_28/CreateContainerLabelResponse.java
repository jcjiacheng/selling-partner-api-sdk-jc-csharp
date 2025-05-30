/*
 * Selling Partner API for Direct Fulfillment Shipping
 * Use the Selling Partner API for Direct Fulfillment Shipping to access a direct fulfillment vendor's shipping data.
 *
 * OpenAPI spec version: 2021-12-28
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package software.amazon.spapi.models.vendor.df.shipping.v2021_12_28;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import software.amazon.spapi.models.vendor.df.shipping.v2021_12_28.ContainerLabel;
/**
 * The response schema for the &#x60;createContainerLabel&#x60; operation.
 */
@Schema(description = "The response schema for the `createContainerLabel` operation.")


public class CreateContainerLabelResponse {
  @SerializedName("containerLabel")
  private ContainerLabel containerLabel = null;

  public CreateContainerLabelResponse containerLabel(ContainerLabel containerLabel) {
    this.containerLabel = containerLabel;
    return this;
  }

   /**
   * Get containerLabel
   * @return containerLabel
  **/
  @Schema(required = true, description = "")
  public ContainerLabel getContainerLabel() {
    return containerLabel;
  }

  public void setContainerLabel(ContainerLabel containerLabel) {
    this.containerLabel = containerLabel;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CreateContainerLabelResponse createContainerLabelResponse = (CreateContainerLabelResponse) o;
    return Objects.equals(this.containerLabel, createContainerLabelResponse.containerLabel);
  }

  @Override
  public int hashCode() {
    return Objects.hash(containerLabel);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CreateContainerLabelResponse {\n");
    
    sb.append("    containerLabel: ").append(toIndentedString(containerLabel)).append("\n");
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
