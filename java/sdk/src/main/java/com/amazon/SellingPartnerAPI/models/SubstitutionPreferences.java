/*
 * Orders v0
 * Use the Orders Selling Partner API to programmatically retrieve order information. With this API, you can develop fast, flexible, and custom applications to manage order synchronization, perform order research, and create demand-based decision support tools.   _Note:_ For the JP, AU, and SG marketplaces, the Orders API supports orders from 2016 onward. For all other marketplaces, the Orders API supports orders for the last two years (orders older than this don't show up in the response).
 *
 * OpenAPI spec version: v0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package com.amazon.SellingPartnerAPI.models;

import java.util.Objects;
import java.util.Arrays;
import com.amazon.SellingPartnerAPI.models.SubstitutionOptionList;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * Substitution preferences for an order item.
 */
@Schema(description = "Substitution preferences for an order item.")


public class SubstitutionPreferences {
  /**
   * The type of substitution that these preferences represent.
   */
  @JsonAdapter(SubstitutionTypeEnum.Adapter.class)
  public enum SubstitutionTypeEnum {
    @SerializedName("CUSTOMER_PREFERENCE")
    CUSTOMER_PREFERENCE("CUSTOMER_PREFERENCE"),
    @SerializedName("AMAZON_RECOMMENDED")
    AMAZON_RECOMMENDED("AMAZON_RECOMMENDED"),
    @SerializedName("DO_NOT_SUBSTITUTE")
    DO_NOT_SUBSTITUTE("DO_NOT_SUBSTITUTE");

    private String value;

    SubstitutionTypeEnum(String value) {
      this.value = value;
    }
    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
    public static SubstitutionTypeEnum fromValue(String input) {
      for (SubstitutionTypeEnum b : SubstitutionTypeEnum.values()) {
        if (b.value.equals(input)) {
          return b;
        }
      }
      return null;
    }
    public static class Adapter extends TypeAdapter<SubstitutionTypeEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final SubstitutionTypeEnum enumeration) throws IOException {
        jsonWriter.value(String.valueOf(enumeration.getValue()));
      }

      @Override
      public SubstitutionTypeEnum read(final JsonReader jsonReader) throws IOException {
        Object value = jsonReader.nextString();
        return SubstitutionTypeEnum.fromValue((String)(value));
      }
    }
  }  @SerializedName("SubstitutionType")
  private SubstitutionTypeEnum substitutionType = null;

  @SerializedName("SubstitutionOptions")
  private SubstitutionOptionList substitutionOptions = null;

  public SubstitutionPreferences substitutionType(SubstitutionTypeEnum substitutionType) {
    this.substitutionType = substitutionType;
    return this;
  }

   /**
   * The type of substitution that these preferences represent.
   * @return substitutionType
  **/
  @Schema(required = true, description = "The type of substitution that these preferences represent.")
  public SubstitutionTypeEnum getSubstitutionType() {
    return substitutionType;
  }

  public void setSubstitutionType(SubstitutionTypeEnum substitutionType) {
    this.substitutionType = substitutionType;
  }

  public SubstitutionPreferences substitutionOptions(SubstitutionOptionList substitutionOptions) {
    this.substitutionOptions = substitutionOptions;
    return this;
  }

   /**
   * Get substitutionOptions
   * @return substitutionOptions
  **/
  @Schema(description = "")
  public SubstitutionOptionList getSubstitutionOptions() {
    return substitutionOptions;
  }

  public void setSubstitutionOptions(SubstitutionOptionList substitutionOptions) {
    this.substitutionOptions = substitutionOptions;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SubstitutionPreferences substitutionPreferences = (SubstitutionPreferences) o;
    return Objects.equals(this.substitutionType, substitutionPreferences.substitutionType) &&
        Objects.equals(this.substitutionOptions, substitutionPreferences.substitutionOptions);
  }

  @Override
  public int hashCode() {
    return Objects.hash(substitutionType, substitutionOptions);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SubstitutionPreferences {\n");
    
    sb.append("    substitutionType: ").append(toIndentedString(substitutionType)).append("\n");
    sb.append("    substitutionOptions: ").append(toIndentedString(substitutionOptions)).append("\n");
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
