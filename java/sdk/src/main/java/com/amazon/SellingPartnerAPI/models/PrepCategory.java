/*
 * Fulfillment Inbound v2024-03-20
 * The Selling Partner API for Fulfillment By Amazon (FBA) Inbound. The FBA Inbound API enables building inbound workflows to create, manage, and send shipments into Amazon's fulfillment network. The API has interoperability with the Send-to-Amazon user interface.
 *
 * OpenAPI spec version: 2024-03-20
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package com.amazon.SellingPartnerAPI.models;

import java.util.Objects;
import java.util.Arrays;
import io.swagger.v3.oas.annotations.media.Schema;
import com.google.gson.annotations.SerializedName;
import java.io.IOException;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;

/**
 * The preparation category for shipping an item to Amazon&#x27;s fulfillment network.
 */
@JsonAdapter(PrepCategory.Adapter.class)
public enum PrepCategory {
  @SerializedName("ADULT")
  ADULT("ADULT"),
  @SerializedName("BABY")
  BABY("BABY"),
  @SerializedName("FC_PROVIDED")
  FC_PROVIDED("FC_PROVIDED"),
  @SerializedName("FRAGILE")
  FRAGILE("FRAGILE"),
  @SerializedName("GRANULAR")
  GRANULAR("GRANULAR"),
  @SerializedName("HANGER")
  HANGER("HANGER"),
  @SerializedName("LIQUID")
  LIQUID("LIQUID"),
  @SerializedName("PERFORATED")
  PERFORATED("PERFORATED"),
  @SerializedName("SET")
  SET("SET"),
  @SerializedName("SHARP")
  SHARP("SHARP"),
  @SerializedName("SMALL")
  SMALL("SMALL"),
  @SerializedName("TEXTILE")
  TEXTILE("TEXTILE"),
  @SerializedName("UNKNOWN")
  UNKNOWN("UNKNOWN"),
  @SerializedName("NONE")
  NONE("NONE");

  private String value;

  PrepCategory(String value) {
    this.value = value;
  }

  public String getValue() {
    return value;
  }

  @Override
  public String toString() {
    return String.valueOf(value);
  }

  public static PrepCategory fromValue(String input) {
    for (PrepCategory b : PrepCategory.values()) {
      if (b.value.equals(input)) {
        return b;
      }
    }
    return null;
  }

  public static class Adapter extends TypeAdapter<PrepCategory> {
    @Override
    public void write(final JsonWriter jsonWriter, final PrepCategory enumeration) throws IOException {
      jsonWriter.value(String.valueOf(enumeration.getValue()));
    }

    @Override
    public PrepCategory read(final JsonReader jsonReader) throws IOException {
      Object value = jsonReader.nextString();
      return PrepCategory.fromValue((String)(value));
    }
  }
}
